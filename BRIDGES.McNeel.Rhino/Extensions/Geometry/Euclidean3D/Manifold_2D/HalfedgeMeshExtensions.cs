using System;
using System.Collections.Generic;

using RH_Geo = Rhino.Geometry;

using Euc3D = BRIDGES.Geometry.Euclidean3D;
using He = BRIDGES.DataStructures.PolyhedralMeshes.HalfedgeMesh;


namespace BRIDGES.McNeel.Rhino.Extensions.Geometry.Euclidean3D
{
    /// <summary>
    /// Class defining casts from <see cref="He.Mesh{TPosition}"/> to <see cref="Rhino"/> objects.
    /// </summary>
    public static class Euclidean3D_HalfedgeMesh_ToRhino
    {
        /// <summary>
        /// Casts a <see cref="He.Mesh{TPosition}"/> to a <see cref="RH_Geo.Mesh"/>.
        /// </summary>
        /// <remarks> 
        /// The order of the vertices and of the face is preserved, but not necessarily the indices. <br/>
        /// If the mesh contains face with more than four vertices, vertices are added to build a corresponding ngon.
        /// </remarks>
        /// <param name="source"> Halfedge mesh data structure from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> Mesh data structure from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        /// <exception cref="InvalidOperationException"> The number of face vertices must be larger than three. </exception>
        public static void ConvertTo(this He.Mesh<Euc3D.Point> source, out RH_Geo.Mesh target)
        {
            target = new RH_Geo.Mesh();

            // Add Vertices
            foreach(He.Vertex<Euc3D.Point> vertex in source.GetVertices())
            {
                RH_Geo.Point3d point = new RH_Geo.Point3d(vertex.Position.X, vertex.Position.Y, vertex.Position.Z);
                target.Vertices.Add(point);
            }

            // Add Faces
            foreach(He.Face<Euc3D.Point> face in source.GetFaces())
            {
                IReadOnlyList<He.Vertex<Euc3D.Point>> vertices = face.FaceVertices();

                int[] i_Vertices = new int[vertices.Count];
                for (int i = 0; i < vertices.Count; i++) { i_Vertices[i] = vertices[i].Index; }

                if (i_Vertices.Length < 3) { throw new InvalidOperationException("The number of face vertices must be larger than three."); }
                else if (i_Vertices.Length == 3) { target.Faces.AddFace(i_Vertices[0], i_Vertices[1], i_Vertices[2]); }
                else if (i_Vertices.Length == 4) { target.Faces.AddFace(i_Vertices[0], i_Vertices[1], i_Vertices[2], i_Vertices[3]); }
                else
                {
                    Euc3D.Point barycentre = new Euc3D.Point(0d, 0d, 0d);
                    for (int i = 0; i < vertices.Count; i++) { barycentre += vertices[i].Position; }
                    barycentre /= vertices.Count;

                    int i_barycentre = target.Vertices.Add(barycentre.X, barycentre.Y, barycentre.Z);

                    int[] i_Faces = new int[vertices.Count];
                    for (int i = 0; i < vertices.Count - 1; i++) { i_Faces[i] = target.Faces.AddFace(i_barycentre, i_Faces[i], i_Faces[i + 1]); }
                    i_Faces[vertices.Count - 1] = target.Faces.AddFace(i_barycentre, i_Faces[vertices.Count - 1], i_Faces[0]);

                    RH_Geo.MeshNgon ngon = RH_Geo.MeshNgon.Create(i_Vertices, i_Faces);
                    target.Ngons.AddNgon(ngon);
                }
            }
        }
    }


    /// <summary>
    /// Class defining casts from <see cref="RH_Geo.Mesh"/> to <see cref="BRIDGES.Geometry.Euclidean3D"/> objects.
    /// </summary>
    public static partial class Rhino_Mesh_ToEuclidean3D
    {
        /// <summary>
        /// Converts a <see cref="RH_Geo.Mesh"/> to a <see cref="He.Mesh{TPosition}"/>.
        /// </summary>
        /// <remarks> The order of the vertices and of the face is preserved, but not necessarily the indices. </remarks>
        /// <param name="source"> Mesh data structure from the <see cref="Rhino"/> framework to cast. </param>
        /// <param name="target"> Halfedge mesh data structure from the <see cref="BRIDGES"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void ConvertTo(this RH_Geo.Mesh source, out He.Mesh<Euc3D.Point> target)
        {
            target = new He.Mesh<Euc3D.Point>();

            // Add Vertices
            foreach(RH_Geo.Point3d rh_Point in source.Vertices)
            {
                rh_Point.CastTo(out Euc3D.Point point);

                target.AddVertex(point);
            }

            /* Add Halfedges :
             * Ensures that the edges indices are preserved but needs access to BRIDGES internals
            
            for (int i_TE = 0; i_TE < source.TopologyEdges.Count; i_TE++)
            {
                Rhino.IndexPair i_EdgeVertices = source.TopologyEdges.GetTopologyVertices(i_TE);

                int[] startIndices = source.TopologyVertices.MeshVertexIndices(i_EdgeVertices.I);
                int[] endIndices = source.TopologyVertices.MeshVertexIndices(i_EdgeVertices.J);

                (int startIndex, int endIndex) = startIndices.Length == 1 & endIndices.Length == 1 ? (startIndices[0], endIndices[0]) :
                    throw new ArgumentException("The mesh does not ensure a one to one correspondance between the vertex list and the topological vertex list.");

                He.Vertex<Euc3D.Point> start = target.GetVertex(startIndex);
                He.Vertex<Euc3D.Point> end = target.GetVertex(endIndex);

                target.AddPair(start, end);
            }
            */

            // Add faces 
            foreach (RH_Geo.MeshNgon ngon in source.GetNgonAndFacesEnumerable())
            {
                uint[] indices = ngon.BoundaryVertexIndexList();

                List<He.Vertex<Euc3D.Point>> vertices = new List<He.Vertex<Euc3D.Point>>(indices.Length);
                for (int i = 0; i < indices.Length; i++) { vertices[i] = target.GetVertex((int)indices[i]); }

                target.AddFace(vertices);
            }
        }
    }
}
