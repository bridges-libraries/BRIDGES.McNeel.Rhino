using System;
using System.Collections.Generic;

using RH_Geo = Rhino.Geometry;

using Euc3D = BRIDGES.Geometry.Euclidean3D;


namespace BRIDGES.McNeel.Rhino.Extensions.Geometry.Euclidean3D
{
    /// <summary>
    /// Class defining casts from <see cref="Euc3D.Plane"/> to <see cref="Rhino"/> objects.
    /// </summary>
    public static class Euclidean3D_Plane_ToRhino
    {
        /******************** Item ********************/

        /// <summary>
        /// Casts a <see cref="Euc3D.Plane"/> to a <see cref="RH_Geo.Plane"/>.
        /// </summary>
        /// <param name="source"> Plane from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> Plane from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this Euc3D.Plane source, out RH_Geo.Plane target)
        {
            source.Origin.CastTo(out RH_Geo.Point3d origin);

            source.UAxis.CastTo(out RH_Geo.Vector3d uAxis);
            source.VAxis.CastTo(out RH_Geo.Vector3d vAxis);
            source.Normal.CastTo(out RH_Geo.Vector3d normal);

            target = new RH_Geo.Plane(origin, uAxis, vAxis) { ZAxis = normal};
        }


        /******************** Array ********************/

        /// <summary>
        /// Casts an array of <see cref="Euc3D.Plane"/> to an array of <see cref="RH_Geo.Plane"/>.
        /// </summary>
        /// <param name="source"> Array of plane from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> Array of plane from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this Euc3D.Plane[] source, out RH_Geo.Plane[] target)
        {
            target = new RH_Geo.Plane[source.Length];
            for (int i = 0; i < source.Length; i++)
            {
                source[i].CastTo(out target[i]);
            }
        }


        /******************** List ********************/

        /// <summary>
        /// Casts a list of <see cref="Euc3D.Plane"/> to a list of <see cref="RH_Geo.Plane"/>.
        /// </summary>
        /// <param name="source"> List of plane from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> List of plane from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this List<Euc3D.Plane> source, out List<RH_Geo.Plane> target)
        {
            target = new List<RH_Geo.Plane>(source.Count);

            for (int i = 0; i < source.Count; i++)
            {
                source[i].CastTo(out RH_Geo.Plane tmp);
                target.Add(tmp);
            }
        }
    }


    /// <summary>
    /// Class defining casts from <see cref="RH_Geo.Plane"/> to <see cref="BRIDGES.Geometry.Euclidean3D"/> objects.
    /// </summary>
    public static partial class Rhino_Plane_ToEuclidean3D
    {
        /******************** Item ********************/

        /// <summary>
        /// Casts a <see cref="RH_Geo.Plane"/> to a <see cref="Euc3D.Plane"/>.
        /// </summary>
        /// <param name="source"> Plane from the <see cref="Rhino"/> framework to cast. </param>
        /// <param name="target"> Plane from the <see cref="BRIDGES"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this RH_Geo.Plane source, out Euc3D.Plane target)
        {
            source.Origin.CastTo(out Euc3D.Point origin);
            source.XAxis.CastTo(out Euc3D.Vector uAxis);
            source.YAxis.CastTo(out Euc3D.Vector vAxis);
            source.ZAxis.CastTo(out Euc3D.Vector normal);

            target = new Euc3D.Plane(origin, uAxis, vAxis, normal);
        }


        /******************** Array ********************/

        /// <summary>
        /// Casts an array of <see cref="RH_Geo.Plane"/> to an array of <see cref="Euc3D.Plane"/>.
        /// </summary>
        /// <param name="source"> Array of plane from the <see cref="Rhino"/> framework to cast. </param>
        /// <param name="target"> Array of plane from the <see cref="BRIDGES"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this RH_Geo.Plane[] source, out Euc3D.Plane[] target)
        {
            target = new Euc3D.Plane[source.Length];
            for (int i = 0; i < source.Length; i++)
            {
                source[i].CastTo(out target[i]);
            }
        }


        /******************** List ********************/

        /// <summary>
        /// Casts a list of <see cref="RH_Geo.Plane"/> to a list of <see cref="Euc3D.Plane"/>.
        /// </summary>
        /// <param name="source"> List of plane from the <see cref="Rhino"/> framework to cast. </param>
        /// <param name="target"> List of plane from the <see cref="BRIDGES"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this List<RH_Geo.Plane> source, out List<Euc3D.Plane> target)
        {
            target = new List<Euc3D.Plane>(source.Count);

            for (int i = 0; i < source.Count; i++)
            {
                source[i].CastTo(out Euc3D.Plane tmp);
                target.Add(tmp);
            }
        }
    }
}
