using System;
using System.Collections.Generic;

using RH_Geo = Rhino.Geometry;

using Euc3D = BRIDGES.Geometry.Euclidean3D;


namespace BRIDGES.McNeel.Rhino.Extensions.Geometry.Euclidean3D
{
    /// <summary>
    /// Class defining casts from <see cref="Euc3D.Vector"/> to <see cref="Rhino"/> objects.
    /// </summary>
    public static class Euclidean3D_Vector_ToRhino
    {
        /******************** Item ********************/

        /// <summary>
        /// Casts a <see cref="Euc3D.Vector"/> to a <see cref="RH_Geo.Vector3d"/>.
        /// </summary>
        /// <param name="source"> Vector from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> Vector from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this Euc3D.Vector source, out RH_Geo.Vector3d target)
        {
            target = new RH_Geo.Vector3d(source.X, source.Y, source.Z);
        }


        /******************** Array ********************/

        /// <summary>
        /// Casts an array of <see cref="Euc3D.Vector"/> to an array of <see cref="RH_Geo.Vector3d"/>.
        /// </summary>
        /// <param name="source"> Array of vector from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> Array of vector from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this Euc3D.Vector[] source, out RH_Geo.Vector3d[] target)
        {
            target = new RH_Geo.Vector3d[source.Length];

            for (int i = 0; i < source.Length; i++)
            {
                target[i].X = source[i].X;
                target[i].Y = source[i].Y;
                target[i].Z = source[i].Z;
            }
        }


        /******************** List ********************/

        /// <summary>
        /// Casts a list of <see cref="Euc3D.Vector"/> to a list of <see cref="RH_Geo.Vector3d"/>.
        /// </summary>
        /// <param name="source"> List of vector from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> List of vector from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this List<Euc3D.Vector> source, out List<RH_Geo.Vector3d> target)
        {
            target = new List<RH_Geo.Vector3d>(source.Count);

            for (int i = 0; i < source.Count; i++)
            {
                target.Add(new RH_Geo.Vector3d(source[i].X, source[i].Y, source[i].Z));
            }
        }
    }


    /// <summary>
    /// Class defining casts from <see cref="RH_Geo.Vector3d"/> to <see cref="BRIDGES.Geometry.Euclidean3D"/> objects.
    /// </summary>
    public static partial class Rhino_Vector3d_ToEuclidean3D
    {
        /******************** Item ********************/

        /// <summary>
        /// Casts a <see cref="RH_Geo.Vector3d"/> to a <see cref="Euc3D.Vector"/>.
        /// </summary>
        /// <param name="source"> Vector from the <see cref="Rhino"/> framework to cast. </param>
        /// <param name="target"> Vector from the <see cref="BRIDGES"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this RH_Geo.Vector3d source, out Euc3D.Vector target)
        {
            target = new Euc3D.Vector(source.X, source.Y, source.Z);
        }
        

        /******************** Array ********************/

        /// <summary>
        /// Casts an array of <see cref="Euc3D.Vector"/> to an array of <see cref="RH_Geo.Vector3d"/>.
        /// </summary>
        /// <param name="source"> Array of vector from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> Array of vector from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this RH_Geo.Vector3d[] source, out Euc3D.Vector[] target)
        {
            target = new Euc3D.Vector[source.Length];

            for (int i = 0; i < source.Length; i++)
            {
                target[i].X = source[i].X;
                target[i].Y = source[i].Y;
                target[i].Z = source[i].Z;
            }
        }


        /******************** List ********************/

        /// <summary>
        /// Casts a list of <see cref="RH_Geo.Vector3d"/> to a list of <see cref="Euc3D.Vector"/>.
        /// </summary>
        /// <param name="source"> List of vector from the <see cref="Rhino"/> framework to cast. </param>
        /// <param name="target"> List of vector from the <see cref="BRIDGES"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this List<RH_Geo.Vector3d> source, out List<Euc3D.Vector> target)
        {
            target = new List<Euc3D.Vector>(source.Count);

            for (int i = 0; i < source.Count; i++)
            {
                target.Add(new Euc3D.Vector(source[i].X, source[i].Y, source[i].Z));
            }
        }
    }
}
