using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Classes
{
    /// <summary>
    /// This class represents a 4x4  matrix
    /// </summary>
    public class Eng_Matrix4x4
    {
        #region Row one Column 1-4
        /// <summary>
        /// row 1 column 1
        /// </summary>
        public double m11 { get; set; }

        /// <summary>
        /// row 1 column 2
        /// </summary>
        public double m12 { get; set; }

        /// <summary>
        /// row 1 column 3
        /// </summary>
        public double m13 { get; set; }

        /// <summary>
        /// row 1 column 4
        /// </summary>
        public double m14 { get; set; }
        #endregion

        #region Row two Column 1-4
        /// <summary>
        /// row 2 column 1
        /// </summary>
        public double m21 { get; set; }

        /// <summary>
        /// row 2 column 2
        /// </summary>
        public double m22 { get; set; }

        /// <summary>
        /// row 2 column 3
        /// </summary>
        public double m23 { get; set; }

        /// <summary>
        /// row 2 column 4
        /// </summary>
        public double m24 { get; set; }
        #endregion

        #region Row three Column 1-4
        /// <summary>
        /// row 3 column 1
        /// </summary>
        public double m31 { get; set; }

        /// <summary>
        /// row 3 column 2
        /// </summary>
        public double m32 { get; set; }

        /// <summary>
        /// row 3 column 3
        /// </summary>
        public double m33 { get; set; }

        /// <summary>
        /// row 3 column 4
        /// </summary>
        public double m34 { get; set; }
        #endregion

        #region Row Four Column 1-4
        /// <summary>
        /// row 4 column 1
        /// </summary>
        public double m41 { get; set; }

        /// <summary>
        /// row 4 column 2
        /// </summary>
        public double m42 { get; set; }

        /// <summary>
        /// row 4 column 3
        /// </summary>
        public double m43 { get; set; }

        /// <summary>
        /// row 4 column 4
        /// </summary>
        public double m44 { get; set; }
        #endregion


        /// <summary>
        /// empty constructor
        /// </summary>
        public Eng_Matrix4x4() { }
        /// <summary>
        /// 4x4 Matrix
        /// </summary>
        /// <param name="m11"></param>
        /// <param name="m12"></param>
        /// <param name="m13"></param>
        /// <param name="m14"></param>
        /// <param name="m21"></param>
        /// <param name="m22"></param>
        /// <param name="m23"></param>
        /// <param name="m24"></param>
        /// <param name="m31"></param>
        /// <param name="m32"></param>
        /// <param name="m33"></param>
        /// <param name="m34"></param>
        /// <param name="m41"></param>
        /// <param name="m42"></param>
        /// <param name="m43"></param>
        /// <param name="m54"></param>
        public Eng_Matrix4x4(
            double m11, double m12, double m13, double m14,
            double m21, double m22, double m23, double m24,
            double m31, double m32, double m33, double m34,
            double m41, double m42, double m43, double m54)
        {
            this.m11 = m11;
            this.m12 = m12;
            this.m13 = m13;
            this.m14 = m14;

            this.m21 = m21;
            this.m22 = m22;
            this.m23 = m23;
            this.m24 = m24;

            this.m31 = m31;
            this.m32 = m32;
            this.m33 = m33;
            this.m34 = m34;

            this.m41 = m41;
            this.m42 = m42;
            this.m43 = m43;
            this.m44 = m44;
        }
    }
}
