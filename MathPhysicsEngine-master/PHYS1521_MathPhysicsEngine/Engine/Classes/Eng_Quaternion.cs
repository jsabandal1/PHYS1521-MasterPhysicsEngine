using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Classes
{
    /// <summary>
    /// This class represents a Quaternion using z-axis heading
    /// </summary>
    public class Eng_Quaternion
    {
        /// <summary>
        /// x coordinate of the 3D vector
        /// </summary>
        public double x { get; set; }

        /// <summary>
        /// y coordinate of the 3D vector
        /// </summary>
        public double y { get; set; }

        /// <summary>
        /// z coordinate of the 3D vecotr
        /// </summary>
        public double z { get; set; }

        /// <summary>
        /// W property of the quaternion
        /// </summary>
        public double w { get; set; }

        /// <summary>
        /// angle property of quaternion
        /// </summary>
        public double angle { get; set; }

        /// <summary>
        /// empty Eng_Vector3D constructor
        /// </summary>
        public Eng_Quaternion() { }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="w"></param>
        public Eng_Quaternion(double x, double y, double z, double w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
            
        }

        /// <summary>
        /// constructor that accepts rotation angle
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="w"></param>
        /// <param name="rotationAngle"></param>
        public Eng_Quaternion(double x, double y, double z, double w, double rotationAngle)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;


            double r = Math.Sin(Calculator.DegreeToRadians(rotationAngle)) / 2;
            double p = Math.Cos(Calculator.DegreeToRadians(rotationAngle)) / 2;
            double h = Math.Sin(Calculator.DegreeToRadians(rotationAngle)) / 2;
        }
    }
}



