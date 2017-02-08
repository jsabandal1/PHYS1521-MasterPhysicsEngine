using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Classes
{
    /// <summary>
    /// This class represents a 3D component vector in 4D homogeneous space
    /// </summary>
    public class Eng_Vector4D
    {

        /// <summary>
        /// W property always 1
        /// </summary>
        public double w;

        /// <summary>
        /// x property
        /// </summary>
        public double x { get; set; }

        /// <summary>
        /// y property
        /// </summary>
        public double y { get; set; }

        /// <summary>
        /// z property
        /// </summary>
        public double z { get; set; }

        /// <summary>
        /// 4D Vector Object
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="w"></param>
        public Eng_Vector4D ( double x, double y, double z, double w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
    }
}
