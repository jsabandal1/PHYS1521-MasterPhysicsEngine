using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Classes
{
    /// <summary>
    /// This class represents a 3D vector in component form
    /// </summary>
    public class Eng_Vector3D
    {
        /// <summary>
        /// x coordinate of the 3D vector
        /// </summary>
        public double x { get; set; }
        
        /// <summary>
        /// z coordinate of the 3D vector
        /// </summary>
        public double y { get; set; }
        
        /// <summary>
        /// z coordinate of the 3D vecotr
        /// </summary>
        public double z { get; set; }

        /// <summary>
        /// magnitude of the 3D vector
        /// </summary>
        public double magnitude;

        /// <summary>
        /// empty Eng_Vector3D constructor
        /// </summary>
        public Eng_Vector3D() { }


        /// <summary>
        /// greedy Eng_Vector3D consturctor
        /// </summary>
        /// <param name="oldX"></param>
        /// <param name="oldY"></param>
        /// <param name="oldZ"></param>
        public Eng_Vector3D(double oldX, double oldY, double oldZ)
        {
            x = oldX;
            y = oldY;
            z = oldZ; 

            magnitude = VectorToMagnitude(x, y, z);
        }


        private double VectorToMagnitude(double x, double y, double z)
        {
            double magnitude;
            magnitude = Math.Sqrt((Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2)));

            return magnitude;
        }
    }
}
