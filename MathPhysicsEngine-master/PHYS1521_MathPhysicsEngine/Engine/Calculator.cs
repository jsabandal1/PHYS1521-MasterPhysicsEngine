using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Classes;

namespace Engine
{
    /// <summary>
    /// This class contains static methods to perform the math calculations.
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Calculates the length of a line segment between two 2D points.
        /// </summary>
        /// <param name="a">Eng_Point2D: a 2D point A</param>
        /// <param name="b">Eng_Point2D: a 2D point B</param>
        /// <returns>Double: length of the line segment.</returns>
        public static double SegmentLength(Eng_Point2D a, Eng_Point2D b)
        {
            return Math.Sqrt(Math.Pow(b.x - a.x, 2) + Math.Pow(b.y - a.y, 2));
        }

        /// <summary>
        /// Calculates the midpoint of the line segment between two 2D points.
        /// </summary>
        /// <param name="a">Eng_Point2D: a 2D point A</param>
        /// <param name="b">Eng_Point2D: a 2D point B</param>
        /// <returns>Eng_Point2D: midpoint on the line segemnt</returns>
        public static Eng_Point2D MidPoint(Eng_Point2D a, Eng_Point2D b)
        {
            return new Eng_Point2D(0.5 * (a.x + b.x), 0.5 * (a.y + b.y));
        }
    }
}
