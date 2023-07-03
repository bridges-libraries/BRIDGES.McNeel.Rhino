using System;
using System.Collections.Generic;

using RH_Geo = Rhino.Geometry;

using Euc3D = BRIDGES.Geometry.Euclidean3D;


namespace BRIDGES.McNeel.Rhino.Extensions.Geometry.Euclidean3D
{
    /// <summary>
    /// Class defining casts from <see cref="Euc3D.Ray"/> to <see cref="Rhino"/> objects.
    /// </summary>
    public static class Euclidean3D_Ray_ToRhino
    {
        /******************** Item ********************/

        /// <summary>
        /// Casts a <see cref="Euc3D.Ray"/> to a <see cref="RH_Geo.Ray3d"/>.
        /// </summary>
        /// <param name="source"> Ray from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> Ray from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this Euc3D.Ray source, out RH_Geo.Ray3d target)
        {
            source.Origin.CastTo(out RH_Geo.Point3d position);
            source.Axis.CastTo(out RH_Geo.Vector3d axis);

            target = new RH_Geo.Ray3d(position, axis);
        }


        /******************** Array ********************/

        /// <summary>
        /// Casts an array of <see cref="Euc3D.Ray"/> to an array of <see cref="RH_Geo.Ray3d"/>.
        /// </summary>
        /// <param name="source"> Array of ray from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> Array of ray from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this Euc3D.Ray[] source, out RH_Geo.Ray3d[] target)
        {
            target = new RH_Geo.Ray3d[source.Length];

            for (int i = 0; i < source.Length; i++)
            {
                source[i].CastTo(out target[i]);
            }
        }


        /******************** List ********************/

        /// <summary>
        /// Casts a list of <see cref="Euc3D.Ray"/> to a list of <see cref="RH_Geo.Ray3d"/>.
        /// </summary>
        /// <param name="source"> List of ray from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> List of ray from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this List<Euc3D.Ray> source, out List<RH_Geo.Ray3d> target)
        {
            target = new List<RH_Geo.Ray3d>(source.Count);

            for (int i = 0; i < source.Count; i++)
            {
                source[i].CastTo(out RH_Geo.Ray3d tmp);
                target.Add(tmp);
            }
        }
    }


    /// <summary>
    /// Class defining casts from <see cref="RH_Geo.Ray3d"/> to <see cref="BRIDGES.Geometry.Euclidean3D"/> objects.
    /// </summary>
    public static partial class Rhino_Ray3d_ToEuclidean3D
    {
        /******************** Item ********************/

        /// <summary>
        /// Casts a <see cref="RH_Geo.Ray3d"/> to a <see cref="Euc3D.Ray"/>.
        /// </summary>
        /// <param name="source"> Ray from the <see cref="Rhino"/> framework to cast. </param>
        /// <param name="target"> Ray from the <see cref="BRIDGES"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this RH_Geo.Ray3d source, out Euc3D.Ray target)
        {
            source.Position.CastTo(out Euc3D.Point position);
            source.Direction.CastTo(out Euc3D.Vector direction);

            target = new Euc3D.Ray(position, direction);
        }


        /******************** Array ********************/

        /// <summary>
        /// Casts an array of <see cref="RH_Geo.Ray3d"/> to an array of <see cref="Euc3D.Ray"/>.
        /// </summary>
        /// <param name="source"> Array of ray from the <see cref="Rhino"/> framework to cast. </param>
        /// <param name="target"> Array of ray from the <see cref="BRIDGES"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this RH_Geo.Ray3d[] source, out Euc3D.Ray[] target)
        {
            target = new Euc3D.Ray[source.Length];

            for (int i = 0; i < source.Length; i++)
            {
                source[i].CastTo(out target[i]);
            }
        }


        /******************** List ********************/

        /// <summary>
        /// Casts a list of <see cref="RH_Geo.Ray3d"/> to a list of <see cref="Euc3D.Ray"/>.
        /// </summary>
        /// <param name="source"> List of ray from the <see cref="Rhino"/> framework to cast. </param>
        /// <param name="target"> List of ray from the <see cref="BRIDGES"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this List<RH_Geo.Ray3d> source, out List<Euc3D.Ray> target)
        {
            target = new List<Euc3D.Ray>(source.Count);

            for (int i = 0; i < source.Count; i++)
            {
                source[i].CastTo(out Euc3D.Ray tmp);
                target.Add(tmp);
            }
        }
    }
}
