using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Classes
{
    /// <summary>
    /// This class simulates a point in 3D LHR space.
    /// </summary>
    public class Eng_Point3D
    {
        /// <summary>
        /// X point
        /// </summary>
        public double x { get; set; }

        /// <summary>
        /// Y point
        /// </summary>
        public double y { get; set; }

        /// <summary>
        /// Z point
        /// </summary>
        public double z { get; set; }

        /// <summary>
        /// greedy constructor
        /// </summary>
        public Eng_Point3D(){ }

        /// <summary>
        /// Represents a 3Dimensional point
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Eng_Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
