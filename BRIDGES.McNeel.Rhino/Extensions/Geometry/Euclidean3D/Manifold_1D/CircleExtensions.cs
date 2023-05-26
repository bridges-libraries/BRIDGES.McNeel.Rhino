using System;
using System.Collections.Generic;

using RH_Geo = Rhino.Geometry;

using Euc3D = BRIDGES.Geometry.Euclidean3D;


namespace BRIDGES.McNeel.Rhino.Extensions.Geometry.Euclidean3D
{
    /// <summary>
    /// Class defining casts from <see cref="Euc3D.Circle"/> to <see cref="Rhino"/> objects.
    /// </summary>
    public static class Euclidean3D_Circle_ToRhino
    {
        /******************** Item ********************/

        /// <summary>
        /// Casts a <see cref="Euc3D.Circle"/> to a <see cref="RH_Geo.Circle"/>.
        /// </summary>
        /// <param name="source"> Circle from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> Circle from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this Euc3D.Circle source, out RH_Geo.Circle target)
        {
            // Define the plane of the Circle
            source.Plane.CastTo(out RH_Geo.Plane plane);

            target = new RH_Geo.Circle(plane, source.Radius);
        }

        /// <summary>
        /// Casts a <see cref="Euc3D.Circle"/> to a <see cref="RH_Geo.Arc"/>.
        /// </summary>
        /// <param name="source"> Circle from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> Arc from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this Euc3D.Circle source, out RH_Geo.Arc target)
        {
            // Define the plane of the Circle
            source.Plane.CastTo(out RH_Geo.Plane plane);

            target = new RH_Geo.Arc(plane, source.Radius, 2 * Math.PI);
        }

        /// <summary>
        /// Casts a <see cref="Euc3D.Circle"/> to a <see cref="RH_Geo.ArcCurve"/>.
        /// </summary>
        /// <param name="source"> Circle from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> Arc curve from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this Euc3D.Circle source, out RH_Geo.ArcCurve target)
        {
            // Define the plane of the Circle
            source.Plane.CastTo(out RH_Geo.Plane plane);

            RH_Geo.Circle circle = new RH_Geo.Circle(plane, source.Radius);
            target = new RH_Geo.ArcCurve(circle);
        }

        /******************** Array ********************/

        /// <summary>
        /// Casts an array of <see cref="Euc3D.Circle"/> to an array of <see cref="RH_Geo.Circle"/>.
        /// </summary>
        /// <param name="source"> Array of circle from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> Array of circle from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this Euc3D.Circle[] source, out RH_Geo.Circle[] target)
        {
            target = new RH_Geo.Circle[source.Length];

            for (int i = 0; i < source.Length; i++)
            {
                source[i].CastTo(out target[i]);
            }
        }

        /// <summary>
        /// Casts an array of <see cref="Euc3D.Circle"/> to an array of <see cref="RH_Geo.Arc"/>.
        /// </summary>
        /// <param name="source"> Array of circle from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> Array of arc from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this Euc3D.Circle[] source, out RH_Geo.Arc[] target)
        {
            target = new RH_Geo.Arc[source.Length];

            for (int i = 0; i < source.Length; i++)
            {
                source[i].CastTo(out target[i]);
            }
        }

        /// <summary>
        /// Casts an array of <see cref="Euc3D.Circle"/> to an array of <see cref="RH_Geo.ArcCurve"/>.
        /// </summary>
        /// <param name="source"> Array of circle from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> Array of arc curve from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this Euc3D.Circle[] source, out RH_Geo.ArcCurve[] target)
        {
            target = new RH_Geo.ArcCurve[source.Length];

            for (int i = 0; i < source.Length; i++)
            {
                source[i].CastTo(out target[i]);
            }
        }

        /******************** List ********************/

        /// <summary>
        /// Casts a list of <see cref="Euc3D.Circle"/> to a list of <see cref="RH_Geo.Circle"/>.
        /// </summary>
        /// <param name="source"> List of circle from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> List of circle from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this List<Euc3D.Circle> source, out List<RH_Geo.Circle> target)
        {
            target = new List<RH_Geo.Circle>(source.Count);

            for (int i = 0; i < source.Count; i++)
            {
                source[i].CastTo(out RH_Geo.Circle tmp);
                target.Add(tmp);
            }
        }

        /// <summary>
        /// Casts a list of <see cref="Euc3D.Circle"/> to a list of <see cref="RH_Geo.Arc"/>.
        /// </summary>
        /// <param name="source"> List of circle from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> List of arc from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this List<Euc3D.Circle> source, out List<RH_Geo.Arc> target)
        {
            target = new List<RH_Geo.Arc>(source.Count);

            for (int i = 0; i < source.Count; i++)
            {
                source[i].CastTo(out RH_Geo.Arc tmp);
                target.Add(tmp);
            }
        }

        /// <summary>
        /// Casts a list of <see cref="Euc3D.Circle"/> to a list of <see cref="RH_Geo.ArcCurve"/>.
        /// </summary>
        /// <param name="source"> List of circle from the <see cref="BRIDGES"/> framework to cast. </param>
        /// <param name="target"> List of arc curve from the <see cref="Rhino"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this List<Euc3D.Circle> source, out List<RH_Geo.ArcCurve> target)
        {
            target = new List<RH_Geo.ArcCurve>(source.Count);

            for (int i = 0; i < source.Count; i++)
            {
                source[i].CastTo(out RH_Geo.ArcCurve tmp);
                target.Add(tmp);
            }
        }
    }


    /// <summary>
    /// Class defining casts from <see cref="RH_Geo.Circle"/> to <see cref="BRIDGES.Geometry.Euclidean3D"/> objects.
    /// </summary>
    public static partial class Rhino_Circle_ToEuclidean3D
    {
        /******************** Item ********************/

        /// <summary>
        /// Casts a <see cref="RH_Geo.Circle"/> to a <see cref="Euc3D.Circle"/>.
        /// </summary>
        /// <param name="source"> Circle from the <see cref="Rhino"/> framework to cast. </param>
        /// <param name="target"> Circle from the <see cref="BRIDGES"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this RH_Geo.Circle source, out Euc3D.Circle target)
        {
            source.Plane.CastTo(out Euc3D.Plane plane);

            target = new Euc3D.Circle(plane, source.Radius);
        }


        /******************** Array ********************/

        /// <summary>
        /// Casts an array of <see cref="RH_Geo.Circle"/> to an array of <see cref="Euc3D.Circle"/>.
        /// </summary>
        /// <param name="source"> Array of circle from the <see cref="Rhino"/> framework to cast. </param>
        /// <param name="target"> Array of circle from the <see cref="BRIDGES"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this RH_Geo.Circle[] source, out Euc3D.Circle[] target)
        {
            target = new Euc3D.Circle[source.Length];
            for (int i = 0; i < source.Length; i++)
            {
                source[i].CastTo(out target[i]);
            }
        }


        /******************** List ********************/

        /// <summary>
        /// Casts a list of <see cref="RH_Geo.Circle"/> to a list of <see cref="Euc3D.Circle"/>.
        /// </summary>
        /// <param name="source"> List of circle from the <see cref="Rhino"/> framework to cast. </param>
        /// <param name="target"> List of circle from the <see cref="BRIDGES"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void CastTo(this List<RH_Geo.Circle> source, out List<Euc3D.Circle> target)
        {
            target = new List<Euc3D.Circle>(source.Count);

            for (int i = 0; i < source.Count; i++)
            {
                source[i].CastTo(out Euc3D.Circle tmp);
                target.Add(tmp);
            }
        }
    }

    /// <summary>
    /// Class defining casts from <see cref="RH_Geo.Arc"/> to <see cref="BRIDGES.Geometry.Euclidean3D"/> objects.
    /// </summary>
    public static partial class Rhino_Arc_ToEuclidean3D
    {
        /******************** Item ********************/

        /// <summary>
        /// Casts a <see cref="RH_Geo.Arc"/> to a <see cref="Euc3D.Circle"/>.
        /// </summary>
        /// <param name="source"> Arc from the <see cref="Rhino"/> framework to cast. </param>
        /// <param name="target"> Circle from the <see cref="BRIDGES"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        /// <exception cref="InvalidCastException"> The arc does not represent a circle. </exception>
        public static void ConvertTo(this RH_Geo.Arc source, out Euc3D.Circle target)
        {
            if (!source.IsCircle) { throw new InvalidCastException("The arc does not represent a circle."); }

            source.Plane.CastTo(out Euc3D.Plane plane);

            target = new Euc3D.Circle(plane, source.Radius);
        }


        /******************** Array ********************/

        /// <summary>
        /// Casts an array of <see cref="RH_Geo.Arc"/> to an array of <see cref="Euc3D.Circle"/>.
        /// </summary>
        /// <param name="source"> Array of arc from the <see cref="Rhino"/> framework to cast. </param>
        /// <param name="target"> Array of circle from the <see cref="BRIDGES"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void ConvertTo(this RH_Geo.Arc[] source, out Euc3D.Circle[] target)
        {
            target = new Euc3D.Circle[source.Length];
            for (int i = 0; i < source.Length; i++)
            {
                source[i].ConvertTo(out target[i]);
            }
        }


        /******************** List ********************/

        /// <summary>
        /// Casts a list of <see cref="RH_Geo.Arc"/> to a list of <see cref="Euc3D.Circle"/>.
        /// </summary>
        /// <param name="source"> List of arc from the <see cref="Rhino"/> framework to cast. </param>
        /// <param name="target"> List of circle from the <see cref="BRIDGES"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void ConvertTo(this List<RH_Geo.Arc> source, out List<Euc3D.Circle> target)
        {
            target = new List<Euc3D.Circle>(source.Count);

            for (int i = 0; i < source.Count; i++)
            {
                source[i].ConvertTo(out Euc3D.Circle tmp);
                target.Add(tmp);
            }
        }
    }

    /// <summary>
    /// Class defining casts from <see cref="RH_Geo.ArcCurve"/> to <see cref="BRIDGES.Geometry.Euclidean3D"/> objects.
    /// </summary>
    public static partial class Rhino_ArcCurve_ToEuclidean3D
    {
        /******************** Item ********************/

        /// <summary>
        /// Casts a <see cref="RH_Geo.ArcCurve"/> to a <see cref="Euc3D.Circle"/>.
        /// </summary>
        /// <param name="source"> Arc curve from the <see cref="Rhino"/> framework to cast. </param>
        /// <param name="target"> Circle from the <see cref="BRIDGES"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        /// <exception cref="InvalidCastException"> The arc curve does not represent a circle. </exception>
        public static void ConvertTo(this RH_Geo.ArcCurve source, out Euc3D.Circle target)
        {
            if (!source.IsCircle()) { throw new InvalidCastException("The arc curve does not represent a circle."); }

            source.Arc.Plane.CastTo(out Euc3D.Plane plane);

            target = new Euc3D.Circle(plane, source.Radius);
        }


        /******************** Array ********************/

        /// <summary>
        /// Casts an array of <see cref="RH_Geo.ArcCurve"/> to an array of <see cref="Euc3D.Circle"/>.
        /// </summary>
        /// <param name="source"> Array of arc curve from the <see cref="Rhino"/> framework to cast. </param>
        /// <param name="target"> Array of circle from the <see cref="BRIDGES"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void ConvertTo(this RH_Geo.ArcCurve[] source, out Euc3D.Circle[] target)
        {
            target = new Euc3D.Circle[source.Length];
            for (int i = 0; i < source.Length; i++)
            {
                source[i].ConvertTo(out target[i]);
            }
        }


        /******************** List ********************/

        /// <summary>
        /// Casts a list of <see cref="RH_Geo.ArcCurve"/> to a list of <see cref="Euc3D.Circle"/>.
        /// </summary>
        /// <param name="source"> List of arc curve from the <see cref="Rhino"/> framework to cast. </param>
        /// <param name="target"> List of circle from the <see cref="BRIDGES"/> framework to cast to. </param>
        /// <returns> <see langword="true"/> if the cast succeeded, <see langword="false"/> otherwise. </returns>
        public static void ConvertTo(this List<RH_Geo.ArcCurve> source, out List<Euc3D.Circle> target)
        {
            target = new List<Euc3D.Circle>(source.Count);

            for (int i = 0; i < source.Count; i++)
            {
                source[i].ConvertTo(out Euc3D.Circle tmp);
                target.Add(tmp);
            }
        }
    }
}
