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
        /// roll cos  roll angle/2
        /// </summary>
        public double c1 { get; set; }

        /// <summary>
        /// pitch cos pitch angle/2
        /// </summary>
        public double c2 { get; set; }

        /// <summary>
        /// yaw cos yaw-angle/2
        /// </summary>
        public double c3 { get; set; }

        /// <summary>
        /// roll sin roll angle/2
        /// </summary>
        public double s1 { get; set; }

        /// <summary>
        /// pitch cos pitch-angle/2
        /// </summary>
        public double s2 { get; set; }

        /// <summary>
        /// yaw siin yaw-angle/2
        /// </summary>
        public double s3 { get; set; }



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
        public double Rollangle { get; set; }

        /// <summary>
        /// angle property of quaternion
        /// </summary>
        public double Pitchangle { get; set; }

        /// <summary>
        /// angle property of quaternion
        /// </summary>
        public double Yawangle { get; set; }

        /// <summary>
        /// empty Eng_Vector3D constructor
        /// </summary>
        public Eng_Quaternion() { }


        /// <summary>
        /// Greedy Constructor that accepts x,y,z,w
        /// </summary>
        /// <param name="w"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Eng_Quaternion(double w, double x, double y, double z)
        {
            this.w = w;
            this.x = x;
            this.y = y;
            this.z = z;
        }

        /// <summary>
        /// Greedy constructor that accepts the roll/pitch/yaw angles
        /// </summary>
        /// <param name="roll"></param>
        /// <param name="pitch"></param>
        /// <param name="yaw"></param>
        public Eng_Quaternion( double yaw, double pitch, double roll)

        {
            Rollangle = roll;
            Pitchangle = pitch;
            Yawangle = yaw;
        }
        internal void SolveRotation()
        {
            c1 = Math.Cos(Calculator.DegreeToRadians(Rollangle) / 2);
            c2 = Math.Cos(Calculator.DegreeToRadians(Pitchangle) / 2);
            c3 = Math.Cos(Calculator.DegreeToRadians(Yawangle) / 2);

            s1 = Math.Sin(Calculator.DegreeToRadians(Rollangle) / 2);
            s2 = Math.Sin(Calculator.DegreeToRadians(Pitchangle) / 2);
            s3 = Math.Sin(Calculator.DegreeToRadians(Yawangle) / 2);
        }
    }
}



