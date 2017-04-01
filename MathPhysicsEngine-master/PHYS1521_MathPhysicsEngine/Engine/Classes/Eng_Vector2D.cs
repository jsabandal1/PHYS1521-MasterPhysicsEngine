using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Classes
{
    /// <summary>
    /// This class represents a 2D Vector in component form
    /// </summary>
    public class Eng_Vector2D
    {
        /// <summary>
        /// x coordinate of the 2D vector
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// y coordinate of the 3D vector
        /// </summary>
        public double y { get; set; }

        /// <summary>
        /// magnitude of the vector
        /// </summary>
        public double magnitude;

        /// <summary>
        /// empty Eng_Vector2D constructor
        /// </summary>
        public Eng_Vector2D() { }


        /// <summary>
        /// greedy Eng_Vector2D consturctor
        /// </summary>
        /// <param name="oldX"></param>
        /// <param name="oldY"></param>
        public Eng_Vector2D (double oldX, double oldY)
        {
            x = oldX;
            y = oldY;

            magnitude = VectorToMagnitude(x, y);
        }


        private double VectorToMagnitude(double x, double y)
        {
            double magnitude;
            magnitude = Math.Sqrt((Math.Pow(x, 2) + Math.Pow(y, 2)));

            return magnitude;
        }


    }


}
