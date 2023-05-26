using System;
using System.Collections.Generic;

using RH_Geo = Rhino.Geometry;

using Euc3D = BRIDGES.Geometry.Euclidean3D;


namespace BRIDGES.McNeel.Rhino.Extensions.Geometry.Euclidean3D
{
    /// <summary>
    /// Class defining casts from <see cref="Euc3D.Line"/> to <see cref="Rhino"/> objects.
    /// </summary>
    public static class Euclidean3D_Line_ToRhino
    {
        /******************** Item ********************/

        /// <summary>
        /// Casts a <see cref="Euc3D.Line"/> to a <see cref="RH_Geo.Line"/>.
        /// </summary>
        /// <param name="source"> Line from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> Line from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this Euc3D.Line source, out RH_Geo.Line target)
        {
            source.Origin.CastTo(out RH_Geo.Point3d start);

            Euc3D.Point pt_AtUnitLength = source.Origin + source.Axis;
            pt_AtUnitLength.CastTo(out RH_Geo.Point3d end);

            target = new RH_Geo.Line(start, end);
        }

        /// <summary>
        /// Casts a <see cref="Euc3D.Line"/> to a <see cref="RH_Geo.LineCurve"/>.
        /// </summary>
        /// <param name="source"> Line from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> Line curve from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this Euc3D.Line source, out RH_Geo.LineCurve target)
        {
            source.Origin.CastTo(out RH_Geo.Point3d start);

            Euc3D.Point pt_AtUnitLength = source.Origin + source.Axis;
            pt_AtUnitLength.CastTo(out RH_Geo.Point3d end);

            target = new RH_Geo.LineCurve(start, end);
        }


        /******************** Array ********************/

        /// <summary>
        /// Casts an array of <see cref="Euc3D.Line"/> to an array of <see cref="RH_Geo.Line"/>.
        /// </summary>
        /// <param name="source"> Array of line from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> Array of line from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this Euc3D.Line[] source, out RH_Geo.Line[] target)
        {
            target = new RH_Geo.Line[source.Length];

            for (int i = 0; i < source.Length; i++)
            {
                source[i].CastTo(out target[i]);
            }
        }

        /// <summary>
        /// Casts an array of <see cref="Euc3D.Line"/> to an array of <see cref="RH_Geo.LineCurve"/>.
        /// </summary>
        /// <param name="source"> Array of line from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> Array of line curve from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this Euc3D.Line[] source, out RH_Geo.LineCurve[] target)
        {
            target = new RH_Geo.LineCurve[source.Length];

            for (int i = 0; i < source.Length; i++)
            {
                source[i].CastTo(out target[i]);
            }
        }


        /******************** List ********************/

        /// <summary>
        /// Casts a list of <see cref="Euc3D.Line"/> to a list of <see cref="RH_Geo.Line"/>.
        /// </summary>
        /// <param name="source"> List of line from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> List of line from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this List<Euc3D.Line> source, out List<RH_Geo.Line> target)
        {
            target = new List<RH_Geo.Line>(source.Count);

            for (int i = 0; i < source.Count; i++)
            {
                source[i].CastTo(out RH_Geo.Line tmp);
                target.Add(tmp);
            }
        }

        /// <summary>
        /// Casts a list of <see cref="Euc3D.Line"/> to a list of <see cref="RH_Geo.LineCurve"/>.
        /// </summary>
        /// <param name="source"> List of line from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> List of line curve from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this List<Euc3D.Line> source, out List<RH_Geo.LineCurve> target)
        {
            target = new List<RH_Geo.LineCurve>(source.Count);

            for (int i = 0; i < source.Count; i++)
            {
                source[i].CastTo(out RH_Geo.LineCurve tmp);
                target.Add(tmp);
            }
        }
    }


    /// <summary>
    /// Class defining casts from <see cref="RH_Geo.Line"/> to <see cref="BRIDGES.Geometry.Euclidean3D"/> objects.
    /// </summary>
    public static partial class Rhino_Line_ToEuclidean3D
    {
        /******************** Item ********************/

        /// <summary>
        /// Casts a <see cref="RH_Geo.Line"/> to a <see cref="Euc3D.Line"/>.
        /// </summary>
        /// <param name="source"> Line from the <see cref="Rhino"/> framework to cast. </param>
        /// <param name="target"> Line from the <see cref="BRIDGES"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this RH_Geo.Line source, out Euc3D.Line target)
        {
            source.From.CastTo(out Euc3D.Point origin);

            RH_Geo.Vector3d direction = source.To - source.From;
            direction.CastTo(out Euc3D.Vector axis);

            target = new Euc3D.Line(origin, axis);
        }


        /******************** Array ********************/

        /// <summary>
        /// Casts an array of <see cref="RH_Geo.Line"/> to an array of <see cref="Euc3D.Line"/>.
        /// </summary>
        /// <param name="source"> Array of line from the <see cref="Rhino"/> framework to cast. </param>
        /// <param name="target"> Array of line from the <see cref="BRIDGES"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this RH_Geo.Line[] source, out Euc3D.Line[] target)
        {
            target = new Euc3D.Line[source.Length];

            for (int i = 0; i < source.Length; i++)
            {
                source[i].CastTo(out target[i]);
            }
        }


        /******************** List ********************/

        /// <summary>
        /// Casts a list of <see cref="RH_Geo.Line"/> to a list of <see cref="Euc3D.Line"/>.
        /// </summary>
        /// <param name="source"> List of line from the <see cref="Rhino"/> framework to cast. </param>
        /// <param name="target"> List of line from the <see cref="BRIDGES"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this List<RH_Geo.Line> source, out List<Euc3D.Line> target)
        {
            target = new List<Euc3D.Line>(source.Count);

            for (int i = 0; i < source.Count; i++)
            {
                source[i].CastTo(out Euc3D.Line tmp);
                target.Add(tmp);
            }
        }
    }

    /// <summary>
    /// Class defining casts from <see cref="RH_Geo.LineCurve"/> to <see cref="BRIDGES.Geometry.Euclidean3D"/> objects.
    /// </summary>
    public static partial class Rhino_LineCurve_ToEuclidean3D
    {
        /******************** Item ********************/

        /// <summary>
        /// Casts a <see cref="RH_Geo.LineCurve"/> to a <see cref="Euc3D.Line"/>.
        /// </summary>
        /// <param name="source"> Line curve from the <see cref="Rhino"/> framework to cast. </param>
        /// <param name="target"> Line from the <see cref="BRIDGES"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this RH_Geo.LineCurve source, out Euc3D.Line target)
        {
            source.PointAtStart.CastTo(out Euc3D.Point origin);

            RH_Geo.Vector3d direction = source.PointAtEnd - source.PointAtStart;
            direction.CastTo(out Euc3D.Vector axis);

            target = new Euc3D.Line(origin, axis);
        }


        /******************** Array ********************/

        /// <summary>
        /// Casts an array of <see cref="RH_Geo.LineCurve"/> to an array of <see cref="Euc3D.Line"/>.
        /// </summary>
        /// <param name="source"> Array of line curve from the <see cref="Rhino"/> framework to cast. </param>
        /// <param name="target"> Array of line from the <see cref="BRIDGES"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this RH_Geo.LineCurve[] source, out Euc3D.Line[] target)
        {
            target = new Euc3D.Line[source.Length];

            for (int i = 0; i < source.Length; i++)
            {
                source[i].CastTo(out target[i]);
            }
        }


        /******************** List ********************/

        /// <summary>
        /// Casts a list of <see cref="RH_Geo.LineCurve"/> to a list of <see cref="Euc3D.Line"/>.
        /// </summary>
        /// <param name="source"> List of line curve from the <see cref="Rhino"/> framework to cast. </param>
        /// <param name="target"> List of line from the <see cref="BRIDGES"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this List<RH_Geo.LineCurve> source, out List<Euc3D.Line> target)
        {
            target = new List<Euc3D.Line>(source.Count);

            for (int i = 0; i < source.Count; i++)
            {
                source[i].CastTo(out Euc3D.Line tmp);
                target.Add(tmp);
            }
        }
    }
}
