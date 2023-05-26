using System;
using System.Collections.Generic;

using RH_Geo = Rhino.Geometry;

using Euc3D = BRIDGES.Geometry.Euclidean3D;


namespace BRIDGES.McNeel.Rhino.Extensions.Geometry.Euclidean3D
{
    /// <summary>
    /// Class defining casts from <see cref="Euc3D.Sphere"/> to <see cref="Rhino"/> objects.
    /// </summary>
    public static class Euclidean3D_Sphere_ToRhino
    {
        /******************** Item ********************/

        /// <summary>
        /// Casts a <see cref="Euc3D.Sphere"/> to a <see cref="RH_Geo.Sphere"/>.
        /// </summary>
        /// <param name="source"> Plane from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> Plane from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static bool CastTo(this Euc3D.Sphere source, out RH_Geo.Sphere target)
        {
            source.Centre.CastTo(out RH_Geo.Point3d origin);

            RH_Geo.Plane plane = new RH_Geo.Plane(origin, RH_Geo.Vector3d.XAxis, RH_Geo.Vector3d.YAxis);

            target = new RH_Geo.Sphere(plane, source.Radius);

            return true;
        }


        /******************** Array ********************/

        /// <summary>
        /// Casts an array of <see cref="Euc3D.Sphere"/> to an array of <see cref="RH_Geo.Sphere"/>.
        /// </summary>
        /// <param name="source"> Array of plane from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> Array of plane from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static bool CastTo(this Euc3D.Sphere[] source, out RH_Geo.Sphere[] target)
        {
            target = new RH_Geo.Sphere[source.Length];
            for (int i = 0; i < source.Length; i++)
            {
                source[i].CastTo(out target[i]);
            }

            return true;
        }


        /******************** List ********************/

        /// <summary>
        /// Casts a list of <see cref="Euc3D.Sphere"/> to a list of <see cref="RH_Geo.Sphere"/>.
        /// </summary>
        /// <param name="source"> List of plane from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> List of plane from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static bool CastTo(this List<Euc3D.Sphere> source, out List<RH_Geo.Sphere> target)
        {
            target = new List<RH_Geo.Sphere>(source.Count);

            for (int i = 0; i < source.Count; i++)
            {
                source[i].CastTo(out RH_Geo.Sphere tmp);
                target.Add(tmp);
            }

            return true;
        }
    }


    /// <summary>
    /// Class defining casts from <see cref="RH_Geo.Sphere"/> to <see cref="BRIDGES.Geometry.Euclidean3D"/> objects.
    /// </summary>
    public static partial class Rhino_Sphere_ToEuclidean3D
    {
        /******************** Item ********************/

        /// <summary>
        /// Casts a <see cref="RH_Geo.Sphere"/> to a <see cref="Euc3D.Sphere"/>.
        /// </summary>
        /// <param name="source"> Plane from the <see cref="Rhino"/> framework to cast. </param>
        /// <param name="target"> Plane from the <see cref="BRIDGES"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static bool CastTo(this RH_Geo.Sphere source, out Euc3D.Sphere target)
        {
            source.Center.CastTo(out Euc3D.Point centre);

            target = new Euc3D.Sphere(centre, source.Radius);

            return true;
        }


        /******************** Array ********************/

        /// <summary>
        /// Casts an array of <see cref="RH_Geo.Sphere"/> to an array of <see cref="Euc3D.Sphere"/>.
        /// </summary>
        /// <param name="source"> Array of plane from the <see cref="Rhino"/> framework to cast. </param>
        /// <param name="target"> Array of plane from the <see cref="BRIDGES"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static bool CastTo(this RH_Geo.Sphere[] source, out Euc3D.Sphere[] target)
        {
            target = new Euc3D.Sphere[source.Length];
            for (int i = 0; i < source.Length; i++)
            {
                source[i].CastTo(out target[i]);
            }

            return true;
        }


        /******************** List ********************/

        /// <summary>
        /// Casts a list of <see cref="RH_Geo.Sphere"/> to a list of <see cref="Euc3D.Sphere"/>.
        /// </summary>
        /// <param name="source"> List of plane from the <see cref="Rhino"/> framework to cast. </param>
        /// <param name="target"> List of plane from the <see cref="BRIDGES"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static bool CastTo(this List<RH_Geo.Sphere> source, out List<Euc3D.Sphere> target)
        {
            target = new List<Euc3D.Sphere>(source.Count);

            for (int i = 0; i < source.Count; i++)
            {
                source[i].CastTo(out Euc3D.Sphere tmp);
                target.Add(tmp);
            }

            return true;
        }
    }
}
