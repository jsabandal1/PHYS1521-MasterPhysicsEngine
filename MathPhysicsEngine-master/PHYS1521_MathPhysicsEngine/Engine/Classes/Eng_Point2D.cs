using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Classes
{
    /// <summary>
    /// This class simulates a point in 2D space.
    /// </summary>
    public class Eng_Point2D
    {
        /// <summary>
        /// This property represents the x-coordinate
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// This property represents the y-coordinate
        /// </summary>
        public double y { get; set; }

        /// <summary>
        /// Empty Eng_Point2D constructor
        /// </summary>
        public Eng_Point2D() { }

        /// <summary>
        /// Greedy Eng_Point2D constructor
        /// </summary>
        /// <param name="x">The x-coordinate</param>
        /// <param name="y">The y-coordinate</param>
        public Eng_Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
