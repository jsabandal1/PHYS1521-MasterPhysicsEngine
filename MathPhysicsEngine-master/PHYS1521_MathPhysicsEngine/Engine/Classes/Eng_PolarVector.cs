using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Classes
{
    /// <summary>
    /// This class represents a 2D vector with magnitude@direction
    /// </summary>
    public class Eng_PolarVector
    {
        /// <summary>
        /// 
        /// </summary>
        public double magnitude { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double direction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double xComponent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double yComponent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double Radians { get; set; }

        /// <summary>
        /// Empty PolarVector Constructor
        /// </summary>
        public Eng_PolarVector() {}

        /// <summary>
        /// greedy constructor that takes X and Y axis and Direction
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="Direction"></param>
        public Eng_PolarVector(double X, double Y, double Direction)
        {
            this.xComponent = X;
            this.yComponent = Y;
            this.direction = Direction;
        }

        /// <summary>
        /// Greedy Constructors that takes magnitude and direction
        /// </summary>
        /// <param name="Magnitude"></param>
        /// <param name="direction"></param>
        public Eng_PolarVector(double Magnitude, double direction)
        {
            this.magnitude = Magnitude;
            this.direction = direction;
        }

        private void getComponent()
        {
            Radians = (Math.PI / 180) * magnitude;

            xComponent = (Math.Sin(Radians)) / magnitude;
            yComponent = (Math.Cos(Radians)) / magnitude;
        }
    }
}
