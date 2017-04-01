using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Classes
{
    /// <summary>
    /// This class represents a Circle for mathematical calculations.
    /// </summary>
    public class Eng_Circle
    {
        /// <summary>
        /// x coordinate of the circle
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// y coordinate of the circle
        /// </summary>
        public double y { get; set; }

        /// <summary>
        /// radius of the circle
        /// </summary>
        public double radius { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double mass { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double Vix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double Viy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="radius"></param>
        public Eng_Circle(double x, double y, double radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="radius"></param>
        /// <param name="mass"></param>
        public Eng_Circle(double x, double y, double radius, double mass)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
            this.mass = mass;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="radius"></param>
        /// <param name="Vix"></param>
        /// <param name="Viy"></param>
        public Eng_Circle(double x, double y, double radius, double Vix, double Viy)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
            this.Vix = Vix;
            this.Viy = Viy;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="radius"></param>
        /// <param name="Vix"></param>
        /// <param name="Viy"></param>
        /// <param name="mass"></param>
        public Eng_Circle(double x, double y, double radius, double Vix, double Viy, double mass)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
            this.Vix = Vix;
            this.Viy = Viy;
            this.mass = mass;
        }
    }
}
