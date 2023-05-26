using System;
using System.Collections.Generic;

using RH_Geo = Rhino.Geometry;

using Euc3D = BRIDGES.Geometry.Euclidean3D;


namespace BRIDGES.McNeel.Rhino.Extensions.Geometry.Euclidean3D
{
    /// <summary>
    /// Class defining casts from <see cref="Euc3D.Polyline"/> to <see cref="Rhino"/> objects.
    /// </summary>
    public static class Euclidean3D_Polyline_ToRhino
    {
        /******************** Item ********************/

        /// <summary>
        /// Casts a <see cref="Euc3D.Polyline"/> to a <see cref="RH_Geo.Polyline"/>.
        /// </summary>
        /// <param name="source"> Polyline from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> Polyline from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this Euc3D.Polyline source, out RH_Geo.Polyline target)
        {
            // In RhinoCommon, polylines are closed if start and end points coincide.
            RH_Geo.Point3d[] vertices = source.IsClosed ? new RH_Geo.Point3d[source.VertexCount + 1] : new RH_Geo.Point3d[source.VertexCount];

            for (int i = 0; i < source.VertexCount; i++)
            {
                 source[i].CastTo(out vertices[i]);
            }
            if (source.IsClosed) { source[0].CastTo(out vertices[vertices.Length - 1]); }

            target = new RH_Geo.Polyline(vertices);
        }

        /// <summary>
        /// Casts a <see cref="Euc3D.Polyline"/> to a <see cref="RH_Geo.Polyline"/>.
        /// </summary>
        /// <param name="source"> Polyline from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> Polyline curve from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this Euc3D.Polyline source, out RH_Geo.PolylineCurve target)
        {
            // In RhinoCommon, polylines are closed if start and end points coincide.
            RH_Geo.Point3d[] vertices = source.IsClosed ? new RH_Geo.Point3d[source.VertexCount + 1] : new RH_Geo.Point3d[source.VertexCount];

            for (int i = 0; i < source.VertexCount; i++)
            {
                source[i].CastTo(out vertices[i]);
            }
            if (source.IsClosed) { source[0].CastTo(out vertices[vertices.Length - 1]); }

            target = new RH_Geo.PolylineCurve(vertices);
        }


        /******************** Array ********************/

        /// <summary>
        /// Casts an array of <see cref="Euc3D.Polyline"/> to an array of <see cref="RH_Geo.Polyline"/>.
        /// </summary>
        /// <param name="source"> Array of polyline from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> Array of polyline from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this Euc3D.Polyline[] source, out RH_Geo.Polyline[] target)
        {
            target = new RH_Geo.Polyline[source.Length];
            for (int i = 0; i < source.Length; i++)
            {
                source[i].CastTo(out target[i]);
            }
        }

        /// <summary>
        /// Casts an array of <see cref="Euc3D.Polyline"/> to an array of <see cref="RH_Geo.PolylineCurve"/>.
        /// </summary>
        /// <param name="source"> Array of polyline from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> Array of polyline curve from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this Euc3D.Polyline[] source, out RH_Geo.PolylineCurve[] target)
        {
            target = new RH_Geo.PolylineCurve[source.Length];
            for (int i = 0; i < source.Length; i++)
            {
                source[i].CastTo(out target[i]);
            }
        }


        /******************** List ********************/

        /// <summary>
        /// Casts a list of <see cref="Euc3D.Polyline"/> to a list of <see cref="RH_Geo.Polyline"/>.
        /// </summary>
        /// <param name="source"> List of polyline from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> List of polyline from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this List<Euc3D.Polyline> source, out List<RH_Geo.Polyline> target)
        {
            target = new List<RH_Geo.Polyline>(source.Count);

            for (int i = 0; i < source.Count; i++)
            {
                source[i].CastTo(out RH_Geo.Polyline tmp);
                target.Add(tmp);
            }
        }

        /// <summary>
        /// Casts a list of <see cref="Euc3D.Polyline"/> to a list of <see cref="RH_Geo.PolylineCurve"/>.
        /// </summary>
        /// <param name="source"> List of polyline from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> List of polyline curve from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this List<Euc3D.Polyline> source, out List<RH_Geo.PolylineCurve> target)
        {
            target = new List<RH_Geo.PolylineCurve>(source.Count);

            for (int i = 0; i < source.Count; i++)
            {
                source[i].CastTo(out RH_Geo.PolylineCurve tmp);
                target.Add(tmp);
            }
        }
    }


    /// <summary>
    /// Class defining casts from <see cref="RH_Geo.Polyline"/> to <see cref="BRIDGES.Geometry.Euclidean3D"/> objects.
    /// </summary>
    public static partial class Rhino_Polyline_ToEuclidean3D
    {
        /******************** Item ********************/

        /// <summary>
        /// Casts a <see cref="RH_Geo.Polyline"/> to a <see cref="Euc3D.Polyline"/>.
        /// </summary>
        /// <param name="source"> Polyline from the <see cref="Rhino"/> framework to cast. </param>
        /// <param name="target"> Polyline from the <see cref="BRIDGES"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this RH_Geo.Polyline source, out Euc3D.Polyline target)
        {
            // In RhinoCommon, polylines are closed if start and end points coincide.
            Euc3D.Point[] vertices = source.IsClosed ? new Euc3D.Point[source.Count - 1] : new Euc3D.Point[source.Count];

            for (int i = 0; i < vertices.Length; i++)
            {
                source[i].CastTo(out vertices[i]);
            }

            target = new Euc3D.Polyline(vertices, source.IsClosed);
        }


        /******************** Array ********************/

        /// <summary>
        /// Casts an array of <see cref="RH_Geo.Polyline"/> to an array of <see cref="Euc3D.Polyline"/>.
        /// </summary>
        /// <param name="source"> Array of polyline from the <see cref="Rhino"/> framework to cast. </param>
        /// <param name="target"> Array of polyline from the <see cref="BRIDGES"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this RH_Geo.Polyline[] source, out Euc3D.Polyline[] target)
        {
            target = new Euc3D.Polyline[source.Length];
            for (int i = 0; i < source.Length; i++)
            {
                source[i].CastTo(out target[i]);
            }
        }


        /******************** List ********************/

        /// <summary>
        /// Casts a list of <see cref="RH_Geo.Polyline"/> to a list of <see cref="Euc3D.Polyline"/>.
        /// </summary>
        /// <param name="source"> List of polyline from the <see cref="Rhino"/> framework to cast. </param>
        /// <param name="target"> List of polyline from the <see cref="BRIDGES"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this List<RH_Geo.Polyline> source, out List<Euc3D.Polyline> target)
        {
            target = new List<Euc3D.Polyline>(source.Count);

            for (int i = 0; i < source.Count; i++)
            {
                source[i].CastTo(out Euc3D.Polyline tmp);
                target.Add(tmp);
            }
        }
    }

    /// <summary>
    /// Class defining casts from <see cref="RH_Geo.PolylineCurve"/> to <see cref="BRIDGES.Geometry.Euclidean3D"/> objects.
    /// </summary>
    public static partial class Rhino_PolylineCurve_ToEuclidean3D
    {
        /******************** Item ********************/

        /// <summary>
        /// Casts a <see cref="RH_Geo.PolylineCurve"/> to a <see cref="Euc3D.Polyline"/>.
        /// </summary>
        /// <param name="source"> Polyline curve from the <see cref="Rhino"/> framework to cast. </param>
        /// <param name="target"> Polyline from the <see cref="BRIDGES"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this RH_Geo.PolylineCurve source, out Euc3D.Polyline target)
        {
            // In RhinoCommon, polylines are closed if start and end points coincide.
            Euc3D.Point[] vertices = source.IsClosed ? new Euc3D.Point[source.PointCount - 1] : new Euc3D.Point[source.PointCount];

            for (int i = 0; i < vertices.Length; i++)
            {
                source.Point(i).CastTo(out vertices[i]);
            }

            target = new Euc3D.Polyline(vertices, source.IsClosed);
        }


        /******************** Array ********************/

        /// <summary>
        /// Casts an array of <see cref="RH_Geo.PolylineCurve"/> to an array of <see cref="Euc3D.Polyline"/>.
        /// </summary>
        /// <param name="source"> Array of polyline curve from the <see cref="Rhino"/> framework to cast. </param>
        /// <param name="target"> Array of polyline from the <see cref="BRIDGES"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this RH_Geo.PolylineCurve[] source, out Euc3D.Polyline[] target)
        {
            target = new Euc3D.Polyline[source.Length];
            for (int i = 0; i < source.Length; i++)
            {
                source[i].CastTo(out target[i]);
            }
        }


        /******************** List ********************/

        /// <summary>
        /// Casts a list of <see cref="RH_Geo.PolylineCurve"/> to a list of <see cref="Euc3D.Polyline"/>.
        /// </summary>
        /// <param name="source"> List of polyline curve from the <see cref="Rhino"/> framework to cast. </param>
        /// <param name="target"> List of polyline from the <see cref="BRIDGES"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this List<RH_Geo.PolylineCurve> source, out List<Euc3D.Polyline> target)
        {
            target = new List<Euc3D.Polyline>(source.Count);

            for (int i = 0; i < source.Count; i++)
            {
                source[i].CastTo(out Euc3D.Polyline tmp);
                target.Add(tmp);
            }
        }
    }
}
