using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Classes
{
    /// <summary>
    /// This class represents a 2x2  matrix
    /// </summary>
    public class Eng_Matrix2x2
    {
        /// <summary>
        /// row 1 column 1
        /// </summary>
        public double m11 { get; set; }

        /// <summary>
        /// row 1 column 2
        /// </summary>
        public double m12 { get; set; }


        /// <summary>
        /// row 2 column 1
        /// </summary>
        public double m21 { get; set; }


        /// <summary>
        /// row 2 column 2
        /// </summary>
        public double m22 { get; set; }

        /// <summary>
        /// 2x2 Matrix
        /// </summary>
        /// <param name="m11"></param>
        /// <param name="m12"></param>
        /// <param name="m21"></param>
        /// <param name="m22"></param>
        public Eng_Matrix2x2(double m11, double m12, double m21, double m22)
        {
            this.m11 = m11;
            this.m12 = m12;
            this.m21 = m21;
            this.m22 = m22;


        }
    }
}
