using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Classes;

namespace Engine
{
    /// <summary>
    /// This class contains static methods to perform the math calculations.
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// 
        /// </summary>
        public const double G = 6.673e-11;
        /// <summary>
        /// Calculates the length of a line segment between two 2D points.
        /// </summary>
        /// <param name="a">Eng_Point2D: a 2D point A</param>
        /// <param name="b">Eng_Point2D: a 2D point B</param>
        /// <returns>Double: length of the line segment.</returns>
        public static double SegmentLength(Eng_Point2D a, Eng_Point2D b)
        {
            return Math.Sqrt(Math.Pow(b.x - a.x, 2) + Math.Pow(b.y - a.y, 2));
        }

        /// <summary>
        /// Calculates the midpoint of the line segment between two 2D points.
        /// </summary>
        /// <param name="a">Eng_Point2D: a 2D point A</param>
        /// <param name="b">Eng_Point2D: a 2D point B</param>
        /// <returns>Eng_Point2D: midpoint on the line segemnt</returns>
        public static Eng_Point2D MidPoint(Eng_Point2D a, Eng_Point2D b)
        {
            return new Eng_Point2D( (a.x + b.x) / 2 ,  (a.y + b.y) / 2);
        }


        #region Trigonometry

        /// <summary>
        /// Converts the angle in degrees to radian
        /// </summary>
        /// <param name="degree"></param>
        /// <returns></returns>
        public static double DegreeToRadians(double degree)
        {
            return degree * (Math.PI / 180);
        }

        /// <summary>
        /// converts the angle in radian to degrees
        /// </summary>
        /// <param name="radian"></param>
        /// <returns></returns>
        public static double RadiansToDegree(double radian)
        {
            return (radian * 180) / Math.PI;
        }

        /// <summary>
        /// Returns side Adjacent and Side Opposite if given is degreeAngle and hypotenuse
        /// </summary>
        /// <param name="degreeAngle"></param>
        /// <param name="hypotenuse"></param>
        /// <returns></returns>
        public static Tuple<double, double> AdjAndOpp(double degreeAngle, double hypotenuse)
        {
            double adjacent;
            double opposite;

            adjacent = Math.Round(Math.Cos(DegreeToRadians(degreeAngle)) * hypotenuse, 4);
            opposite = Math.Round(Math.Sin(DegreeToRadians(degreeAngle)) * hypotenuse, 4);

            return new Tuple<double, double>(Math.Round(adjacent, 4), Math.Round(opposite, 4));
        }

        /// <summary>
        /// returns side adjacent and side hypotenuse if given is angle in degrees and side opposite
        /// </summary>
        /// <param name="degreeAngle"></param>
        /// <param name="opposite"></param>
        /// <returns></returns>
        public static Tuple<double, double> AdjAndHypo(double degreeAngle, double opposite)
        {
            double adjacent;
            double hypotenuse;

            adjacent = (Math.Tan(DegreeToRadians(degreeAngle)) * opposite);
            //hypotenuse = Math.Round(Math.Sin(DegreeToRadians(degreeAngle)) * adjacent, 4);
            hypotenuse = opposite / (Math.Sin(DegreeToRadians( degreeAngle)));
            return new Tuple<double, double>(adjacent, hypotenuse);
        }

        /// <summary>
        /// returns a side Opposite and side Hypotenuse if given is angle in degrees and side adjacent
        /// </summary>
        /// <param name="degreeAngle"></param>
        /// <param name="adjacent"></param>
        /// <returns></returns>
        public static Tuple<double, double> OppAndHypo(double degreeAngle, double adjacent)
        {
            double opposite;
            double hypotenuse;

            opposite = Math.Round(Math.Tan(DegreeToRadians(degreeAngle)) * adjacent, 4);
            hypotenuse = Math.Round(adjacent / (Math.Cos(DegreeToRadians(degreeAngle))), 4);

            return new Tuple<double, double>(Math.Round(opposite, 4), Math.Round(hypotenuse, 4));
        }

        /// <summary>
        /// Returns a Side and Angle in degrees if given is side Opposite and side Adjacent
        /// </summary>
        /// <param name="sideOpp"></param>
        /// <param name="sideAdj"></param>
        /// <returns></returns>
        public static Tuple<double, double> HypoTheta(double sideOpp, double sideAdj)
        {
            double hypotenuse;
            double givenAngle;

            givenAngle = RadiansToDegree((Math.Atan(sideOpp / sideAdj)));
            hypotenuse = (sideOpp / (Math.Sin(DegreeToRadians(givenAngle))));

            return new Tuple<double, double>(Math.Round(hypotenuse, 4), Math.Round(givenAngle, 4));
        }

        /// <summary>
        /// returns a missing Side and missing angle in degrees if given is side Opposite and side Hypotenuse
        /// </summary>
        /// <param name="sideOpp"></param>
        /// <param name="sideHypo"></param>
        /// <returns></returns>
        public static Tuple<double, double> AdjTheta(double sideOpp, double sideHypo)
        {
            double missingAngle;
            double missingSide;

            missingAngle = Math.Round(RadiansToDegree(Math.Asin(sideOpp / sideHypo)), 4);
            missingSide = Math.Round(Math.Cos(DegreeToRadians(missingAngle)) * sideHypo, 4);

            return new Tuple<double, double>(Math.Round(missingSide, 4), Math.Round(missingAngle, 4));

        }

        /// <summary>
        /// returns a side and angle in degrees if the given is side adjacent and side hypotenuse
        /// </summary>
        /// <param name="SideAdj"></param>
        /// <param name="sideHypo"></param>
        /// <returns></returns>
        public static Tuple<double, double> OppoTheta(double SideAdj, double sideHypo)
        {
            double sideOpp;
            double missingAngle;

            missingAngle = RadiansToDegree(Math.Acos(SideAdj / sideHypo));
            sideOpp = Math.Sin(DegreeToRadians(missingAngle)) * sideHypo;

            return new Tuple<double, double>(Math.Round(sideOpp, 4), Math.Round(missingAngle, 4));
        }
        #endregion

        #region 2D Vectors

        /// <summary>
        /// Adding two 2D Vectors
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static Eng_Vector2D AddTwo2DVectors(Eng_Vector2D first, Eng_Vector2D second)
        {

            return new Eng_Vector2D(first.x + second.x, first.y + second.y);
        }

        /// <summary>
        /// Dot Product of two 2D Vectors
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static double DotProductofTwo2DVectors(Eng_Vector2D first, Eng_Vector2D second)
        {
            //(Vax * Vbx) + (Vay * Vby)
            return ((first.x * second.x) + (first.y * second.y));
        }

        /// <summary>
        /// Calculating the angle of two 2D Vecors in degrees
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static double AngleBetweenTwo2DVectors(Eng_Vector2D first, Eng_Vector2D second)
        {
            double angle;


            // angle =  = cos^-1 ( A * B / ||A|| * ||B|| ) 
            angle = Math.Acos(((DotProductofTwo2DVectors(first, second)) / ((first.magnitude) * (second.magnitude))));

            return angle;
        }

        /// <summary>
        /// getting the surface normal of a 2D vecotr
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public static double SurfaceNormalOfA2DVector(Eng_Vector2D first)
        {
            double topX = first.x / first.magnitude;
            double bottomY = first.y / first.magnitude;

            Eng_Vector2D surfaceVector = new Eng_Vector2D(topX, bottomY);

            return surfaceVector.magnitude;
        }
        #endregion

        #region 3D Vectors fam

        /// <summary>
        /// Adding two 3D Vectors
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static Eng_Vector3D AddTwo3DVectors(Eng_Vector3D first, Eng_Vector3D second)
        {

            return new Eng_Vector3D(first.x + second.x, first.y + second.y, first.z + second.z);
        }

        /// <summary>
        /// Dot Product of two 3D Vectors
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static double DotProductofTwo3DVectors(Eng_Vector3D first, Eng_Vector3D second)
        {
            //(Vax * Vbx) + (Vay * Vby)
            return ((first.x * second.x) + (first.y * second.y) + (first.z * second.z));
        }

        /// <summary>
        /// Solving the cross product of two 3D vectors
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static Eng_Vector3D CrossVectorProduct3D(Eng_Vector3D first, Eng_Vector3D second)
        {

            return new Eng_Vector3D((first.y * second.z) - (first.z * second.y),
                                       (first.z * second.x) - (first.x * second.z),
                                       (first.x * second.y) - (first.y * second.x));
        }

        /// <summary>
        /// Solving the Angle between two 3D Vectors
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static double AngleBetweenTwo3DVectors(Eng_Vector3D first, Eng_Vector3D second)
        {
            double angle;
            // angle =  = cos^-1 ( A * B / ||A|| * ||B|| ) 
            angle = DegreeToRadians(Math.Acos(DotProductofTwo3DVectors(first, second) / (first.magnitude * second.magnitude)));

            return angle;
        }

        /// <summary>
        /// Surface normal of a 3D Vector
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public static Eng_Vector3D SurfaceNormalOfA3DVector(Eng_Vector3D first)
        {
            double topX = first.x / first.magnitude;
            double middleY = first.y / first.magnitude;
            double bottomZ = first.z / first.magnitude;

            Eng_Vector3D surfaceVector = new Eng_Vector3D(topX, middleY, bottomZ);

            return surfaceVector;
        }
        #endregion

        #region Matrices

        /// <summary>
        /// Multyiplying a 4x4 Matrix and a 4D vector
        /// </summary>
        /// <param name="vector"></param>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static Eng_Vector4D MultiplyVectorMatrix(Eng_Vector4D vector, Eng_Matrix4x4 matrix)
        {

            return new Eng_Vector4D /*this is X*/((matrix.m11 * vector.x)+(matrix.m12 * vector.y) +(matrix.m13 * vector.z) +(matrix.m14 * vector.w),
                                    /*this is Y*/ (matrix.m21 * vector.x) + (matrix.m22 * vector.y) + (matrix.m23 * vector.z) + (matrix.m24 * vector.w),
                                    /*this is Z*/ (matrix.m31 * vector.x) + (matrix.m32 * vector.y) + (matrix.m33 * vector.z) + (matrix.m34 * vector.w),
                                    /*this is W*/(matrix.m41 * vector.x) + (matrix.m42 * vector.y) + (matrix.m43 * vector.z) + (matrix.m44 * vector.w)) ;
        }

        /// <summary>
        /// Multiplication of a 3x3 vector to a 3x3matrix
        /// </summary>
        /// <param name="vector"></param>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static Eng_Vector3D MultiplyVectorMatrix3x3(Eng_Vector3D vector, Eng_Matrix3x3 matrix)
        {

            return new Eng_Vector3D /*this is X*/((matrix.m11 * vector.x) + (matrix.m12 * vector.y) + (matrix.m13 * vector.z), 
                                    /*this is Y*/ (matrix.m21 * vector.x) + (matrix.m22 * vector.y) + (matrix.m23 * vector.z),
                                    /*this is Z*/ (matrix.m31 * vector.x) + (matrix.m32 * vector.y) + (matrix.m33 * vector.z));

        }

        /// <summary>
        /// multiplying two 4x4 matrix 
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static Eng_Matrix4x4 MultiplyTwo4x4Matrix(Eng_Matrix4x4 first, Eng_Matrix4x4 second)
        {
            //𝑎11𝑏11 + 𝑎12𝑏21 + 𝑎13𝑏31 ----𝑎11𝑏12 + 𝑎12𝑏22 + 𝑎13𝑏32--- 𝑎11𝑏13 + 𝑎12𝑏23 + 𝑎13𝑏33
            return new Eng_Matrix4x4(
                /*m11*/(first.m11 * second.m11) + (first.m12 * second.m21) + (first.m13 * second.m31) + (first.m14 * second.m41),
                /*m12*/(first.m11 * second.m12) + (first.m12 * second.m22) + (first.m13 * second.m32) + (first.m14 * second.m42),
                /*m13*/(first.m11 * second.m13) + (first.m12 * second.m23) + (first.m13 * second.m33) + (first.m14 * second.m43),
                /*m14*/(first.m11 * second.m14) + (first.m12 * second.m24) + (first.m13 * second.m34) + (first.m14 * second.m44),

                /*m21*/(first.m21 * second.m11) + (first.m22 * second.m21) + (first.m23 * second.m31) + (first.m24 * second.m41),
                /*m22*/(first.m21 * second.m12) + (first.m22 * second.m22) + (first.m23 * second.m32) + (first.m24 * second.m42),
                /*m23*/(first.m21 * second.m13) + (first.m22 * second.m23) + (first.m23 * second.m33) + (first.m24 * second.m43),
                /*m24*/(first.m21 * second.m14) + (first.m22 * second.m24) + (first.m23 * second.m34) + (first.m24 * second.m44),

                /*m31*/(first.m31 * second.m11) + (first.m32 * second.m21) + (first.m33 * second.m31) + (first.m34 * second.m41),
                /*m32*/(first.m31 * second.m12) + (first.m32 * second.m22) + (first.m33 * second.m32) + (first.m34 * second.m42),
                /*m33*/(first.m31 * second.m13) + (first.m32 * second.m23) + (first.m33 * second.m33) + (first.m34 * second.m43),
                /*m34*/(first.m31 * second.m14) + (first.m32 * second.m24) + (first.m33 * second.m34) + (first.m34 * second.m44),

                /*m41*/(first.m41 * second.m11) + (first.m42 * second.m21) + (first.m43 * second.m31) + (first.m44 * second.m41),
                /*m42*/(first.m41 * second.m12) + (first.m42 * second.m22) + (first.m43 * second.m32) + (first.m44 * second.m42),
                /*m43*/(first.m41 * second.m13) + (first.m42 * second.m23) + (first.m43 * second.m33) + (first.m44 * second.m43),
                /*m44*/(first.m41 * second.m14) + (first.m42 * second.m24) + (first.m43 * second.m34) + (first.m44 * second.m44));
        }
        /// <summary>
        /// Transposes a 4x4 matrix
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public static Eng_Matrix4x4 TransposeMatrix(Eng_Matrix4x4 first)
        {
            //double m11, double m12, double m13, double m14,
            //double m21, double m22, double m23, double m24,
            //double m31, double m32, double m33, double m34,
            //double m41, double m42, double m43, double m54)
            return new Eng_Matrix4x4(first.m11, first.m21, first.m31, first.m41,
                                     first.m12, first.m22, first.m32, first.m42,
                                     first.m13, first.m23, first.m33, first.m43,
                                     first.m14, first.m24, first.m34, first.m44);
        }

        /// <summary>
        /// calculate the determinant of a 4x4 matrix
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public static double CalculateDeterminant4x4(Eng_Matrix4x4 first)
        {
        return (first.m11 * first.m22 * first.m33 * first.m44 + 
                first.m12 * first.m23 * first.m34 * first.m41 + 
                first.m13 * first.m24 * first.m31 * first.m42 + 
                first.m14 * first.m21 * first.m32 * first.m43 - 
                first.m14 * first.m23 * first.m32 * first.m41 - 
                first.m13 * first.m22 * first.m31 * first.m44 - 
                first.m12 * first.m21 * first.m34 * first.m43 - 
                first.m11 * first.m24 * first.m33 * first.m42);
        }
        /// <summary>
        /// inverse of a 4x4 matrix
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public static Eng_Matrix4x4 InverseOfA4x4Matrix(Eng_Matrix4x4 m)
        {
            //22 33 44 --- 23 34 42 --- 24 32 43 --- 22 34 43 --- 23 32 44 --- 24 33 42
            double multiplier = 1 / CalculateDeterminant4x4(m);
            return new Eng_Matrix4x4
        ( multiplier * (m.m22 * m.m33 * m.m44 + m.m23 * m.m34 * m.m42 + m.m24 * m.m32 * m.m43 - m.m22 * m.m34 * m.m43 - m.m23 * m.m32 * m.m44 - m.m24 * m.m33 * m.m42),
            multiplier * (m.m12 * m.m34 * m.m43 + m.m13 * m.m32 * m.m44 + m.m14 * m.m33 * m.m42 - m.m12 * m.m33 * m.m44 - m.m13 * m.m34 * m.m42 - m.m14 * m.m32 * m.m43),
            multiplier * (m.m12 * m.m23 * m.m44 + m.m13 * m.m24 * m.m42 + m.m14 * m.m22 * m.m43 - m.m12 * m.m24 * m.m43 - m.m13 * m.m22 * m.m44 - m.m14 * m.m23 * m.m42),
            multiplier * (m.m12 * m.m24 * m.m33 + m.m13 * m.m22 * m.m34 + m.m14 * m.m23 * m.m32 - m.m12 * m.m23 * m.m34 - m.m13 * m.m24 * m.m32 - m.m14 * m.m22 * m.m33),
            multiplier * (m.m21 * m.m34 * m.m43 + m.m23 * m.m31 * m.m44 + m.m24 * m.m33 * m.m41 - m.m21 * m.m33 * m.m44 - m.m23 * m.m34 * m.m41 - m.m24 * m.m31 * m.m43),
            multiplier * (m.m11 * m.m33 * m.m44 + m.m13 * m.m34 * m.m41 + m.m14 * m.m31 * m.m43 - m.m11 * m.m34 * m.m43 - m.m13 * m.m31 * m.m44 - m.m14 * m.m33 * m.m41),
            multiplier * (m.m11 * m.m24 * m.m43 + m.m13 * m.m21 * m.m44 + m.m14 * m.m23 * m.m41 - m.m11 * m.m23 * m.m44 - m.m13 * m.m24 * m.m41 - m.m14 * m.m21 * m.m43),
            multiplier * (m.m11 * m.m23 * m.m34 + m.m13 * m.m24 * m.m31 + m.m14 * m.m21 * m.m33 - m.m11 * m.m24 * m.m33 - m.m13 * m.m21 * m.m34 - m.m14 * m.m23 * m.m31),
            multiplier * (m.m21 * m.m32 * m.m44 + m.m22 * m.m34 * m.m41 + m.m24 * m.m31 * m.m42 - m.m21 * m.m34 * m.m42 - m.m22 * m.m31 * m.m44 - m.m24 * m.m32 * m.m41),
            multiplier * (m.m11 * m.m34 * m.m42 + m.m12 * m.m31 * m.m44 + m.m14 * m.m32 * m.m41 - m.m11 * m.m32 * m.m44 - m.m12 * m.m34 * m.m41 - m.m14 * m.m31 * m.m42),
            Math.Round(multiplier * (m.m11 * m.m22 * m.m44 + m.m12 * m.m24 * m.m41 + m.m14 * m.m21 * m.m42 - m.m11 * m.m24 * m.m42 - m.m12 * m.m21 * m.m44 - m.m14 * m.m22 * m.m41),4),
            Math.Round(multiplier * (m.m11 * m.m24 * m.m32 + m.m12 * m.m21 * m.m34 + m.m14 * m.m22 * m.m31 - m.m11 * m.m22 * m.m34 - m.m12 * m.m24 * m.m31 - m.m14 * m.m21 * m.m32),4),
            multiplier * (m.m21 * m.m33 * m.m42 + m.m22 * m.m31 * m.m43 + m.m23 * m.m32 * m.m41 - m.m21 * m.m32 * m.m43 - m.m22 * m.m33 * m.m41 - m.m23 * m.m31 * m.m42),
            multiplier * (m.m11 * m.m32 * m.m43 + m.m12 * m.m33 * m.m41 + m.m13 * m.m31 * m.m42 - m.m11 * m.m33 * m.m42 - m.m12 * m.m31 * m.m43 - m.m13 * m.m32 * m.m41),
            multiplier * (m.m11 * m.m23 * m.m42 + m.m12 * m.m21 * m.m43 + m.m13 * m.m22 * m.m41 - m.m11 * m.m22 * m.m43 - m.m12 * m.m23 * m.m41 - m.m13 * m.m21 * m.m42),
            multiplier * (m.m11 * m.m22 * m.m33 + m.m12 * m.m23 * m.m31 + m.m13 * m.m21 * m.m32 - m.m11 * m.m23 * m.m32 - m.m12 * m.m21 * m.m33 - m.m13 * m.m22 * m.m31));

        }


        #endregion

        #region 2D Rotations
        /// <summary>
        /// Rotation Matrix of two 2D point
        /// </summary>
        /// <param name="degree"></param>
        /// <returns></returns>
        public static Eng_Matrix3x3 RotationMatrix(double degree)
        {
            return new Eng_Matrix3x3(Math.Cos(DegreeToRadians(degree)), -Math.Sin(DegreeToRadians(degree)), 0, Math.Sin(DegreeToRadians(degree)), Math.Cos(DegreeToRadians(degree)), 0, 0, 0, 1);
        }
        #endregion


        #region 3D Rotation
        /// <summary>
        /// quternion to matrix conversion
        /// </summary>
        /// <param name="quat"></param>
        /// <returns></returns>
        public static Eng_Matrix4x4 QuaternionToMatrixConversion(Eng_Quaternion quat)
        {
            return new Eng_Matrix4x4
                 (1 - (2 * (Math.Pow(quat.y, 2) + Math.Pow(quat.z, 2))),
                 2 * (quat.x * quat.y - quat.w * quat.z),
                 2 * (quat.x * quat.z + quat.w * quat.y)
                 ,0,
                 2 * (quat.x * quat.y + quat.w * quat.z),
                 1 - 2 * (Math.Pow(quat.x, 2) + Math.Pow(quat.z, 2)),
                 2 * (quat.y * quat.z - quat.w * quat.x),
                 0,
                 2 * (quat.x * quat.z - quat.w * quat.y),
                 2 * (quat.y * quat.z + quat.w * quat.x),
                 1 - 2 * (Math.Pow(quat.x, 2) + Math.Pow(quat.y, 2)),
                 0,
                 0,0,0,1);
        }

        /// <summary>
        /// quaternion to euler
        /// </summary>
        /// <param name="q"></param>
        /// <returns></returns>
        public static Tuple<double, double, double> CalculateEulerFromQuaternion(Eng_Quaternion q)
        {
            //𝑃 = sin−1(−2(𝑄𝑦𝑄𝑧 − 𝑄𝑤𝑄𝑥)) 
            double pitch =RadiansToDegree( Math.Asin(-2 * (q.y * q.z - q.w * q.x)));
            double yaw = RadiansToDegree( Math.Atan((2 * (q.x * q.z + q.w * q.y ))/ (1 - 2 * (Math.Pow(q.x, 2) + Math.Pow(q.y, 2)))));
            double roll = RadiansToDegree(Math.Atan((2 * (q.x * q.y + q.w * q.z)) / (1 - 2 * (Math.Pow(q.x, 2) + Math.Pow(q.y, 2)))));

            return new Tuple<double, double, double>(pitch, yaw, roll);
                
        }
        #endregion

        #region Lab003
        /// <summary>
        /// Returns two 2D points velocity and displacement (Velocity X and Y, Displacement X and Y)
        /// </summary>
        /// <param name="AccelarationX"></param>
        /// <param name="AccelarationY"></param>
        /// <param name="time"></param>
        /// <param name="VelocityInitialX"></param>
        /// <param name="VelocityInitialY"></param>
        /// <returns></returns>
        public static Tuple<double, double, double, double> VelocityFinalAndDisplacementXnY(double AccelarationX, double AccelarationY, double time, double VelocityInitialX, double VelocityInitialY)
        {
            double VelocityFinalX;
            double VelocityFinalY;
            double DisplacementX;
            double DisplacementY;

            DisplacementX = VelocityInitialX * time + 1 / 2 * AccelarationX * (Math.Pow(time, 2));
            DisplacementY = VelocityInitialY * time + 1 / 2 * -AccelarationY * Math.Pow(time, 2);

            // vf =vi+a*t
            VelocityFinalX = VelocityInitialX + (AccelarationX * time);
            VelocityFinalY = VelocityInitialY + (AccelarationY * time);

            return new Tuple<double, double, double, double>(VelocityFinalX, VelocityFinalY, DisplacementX, DisplacementY);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gravity"></param>
        /// <param name="LaunchAngle"></param>
        /// <param name="VelocityAtAngle"></param>
        /// <param name="PlatformHeight"></param>
        /// <returns></returns>
        public static Tuple<double, double, double> DisplacementXnMaxHeightnTime(double gravity, double LaunchAngle, double VelocityAtAngle, double PlatformHeight)
        {
            double Viy = Math.Sin(LaunchAngle) * VelocityAtAngle;
            double Vix = Math.Cos(LaunchAngle) * VelocityAtAngle;

            double Time1 = (-Viy - (Math.Sqrt((Math.Pow(Viy, 2) - (4 * gravity * PlatformHeight))))) / (2 * gravity);

            //the horizontal displacement of a projectile, its max height, and time
            double displacementX = Vix * Time1 + 0.5 * 0 * Math.Pow(Time1, 2);
            double apex = -Viy / gravity;
            double maxHeight = apex * Viy + (0.5 * gravity) * (Math.Pow(apex,2));


            return new Tuple<double, double, double>(displacementX, maxHeight, Time1);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="RPM"></param>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static Tuple<double, double> RadPerSecAndAcceleration(double RPM, double radius)
        {
            double RotationalSpeed = RPM * 1 / 60 * 2 * Math.PI;
            double AngularAcceleration = radius * Math.Pow(RotationalSpeed, 2);
            return new Tuple<double, double>(RotationalSpeed, AngularAcceleration);
        }
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ArcLength"></param>
        /// <param name="RadiusOfRotation"></param>
        /// <param name="Time"></param>
        /// <returns></returns>
        public static Tuple<double, double, double, double> ChangeInThetaAngularVelocityAndAccelerationAndTangentialVelocity(double ArcLength, double RadiusOfRotation, double Time)
        {
            double changeTheta = ArcLength / RadiusOfRotation;
            double angularVelocity = changeTheta / Time;
            double angularAcceleration = angularVelocity / Time;
            double tangentialVelocity = RadiusOfRotation * angularVelocity;

            return new Tuple<double, double, double, double>(changeTheta, angularVelocity, angularAcceleration, tangentialVelocity);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="angularVelocity"></param>
        /// <param name="Radius1"></param>
        /// <param name="Radius2"></param>
        /// <returns></returns>
        public static Tuple<double, double> TangentialVelocityOfTwoObjects(double angularVelocity, double Radius1, double Radius2)
        {
            double object1 = Radius1 * angularVelocity;
            double object2 = Radius2 * angularVelocity;

            return new Tuple<double, double>(object1, object2);
        }


        //public static Tuple<double,double> CalculateNetForceAndAcceleration(double AppliedForce, double ForceOfFriction, double ForceOfGravity)
        //{ }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mass"></param>
        /// <param name="Radius"></param>
        /// <returns></returns>
        public static double surfaceGravityOfCelestialBody(double Mass, double Radius)
        {
            //cause gravity pulls down so negative
            return -(G * Mass / (Radius * Radius));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mass1"></param>
        /// <param name="Mass2"></param>
        /// <param name="Radius"></param>
        /// <returns></returns>
        public static double ForceAttractionOfTwoObjects(double Mass1, double Mass2, double Radius)
        {
            return G * Mass1 * Mass2 / (Radius * Radius);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mass"></param>
        /// <param name="stretch"></param>
        /// <param name="Gravity"></param>
        /// <returns></returns>
        public static double CalculateSpringConstant(double mass, double stretch, double Gravity)
        {
            return -mass * Gravity / stretch;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="k"></param>
        /// <param name="mass"></param>
        /// <param name="stretchedLength"></param>
        /// <returns></returns>
        public static Tuple<double,double> SpringFreqAndVelocity(double k, double mass, double stretchedLength)
        {
            // 𝜔 = √k ---- Frequency = ( 1 / 2 * Math.PI ) * (Math.Sqrt(k / m); ----- velocity = stretchLength * Math.Sqrt(K / mass);
            double Frequency = (1 / (2 * Math.PI)) * (Math.Sqrt(k / mass));
            double Velocity = stretchedLength * Math.Sqrt(k / mass);

            return new Tuple<double, double>(Frequency, Velocity);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mass"></param>
        /// <param name="Vi"></param>
        /// <param name="breakForce"></param>
        /// <returns></returns>
        public static Tuple<double, double> CalculateTimeAndMomentum(double mass, double Vi, double breakForce)
        {
            double momentum = mass * Vi,

            time = momentum / breakForce;

            return new Tuple<double, double>(momentum, time);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aX"></param>
        /// <param name="aY"></param>
        /// <param name="aR"></param>
        /// <param name="aMass"></param>
        /// <param name="aViX"></param>
        /// <param name="aViY"></param>
        /// <param name="bX"></param>
        /// <param name="bY"></param>
        /// <param name="bR"></param>
        /// <param name="bMass"></param>
        /// <param name="bViX"></param>
        /// <param name="bViY"></param>
        /// <returns></returns>
        public static Tuple<Eng_Vector2D, Eng_Vector2D> FinalVelocityOfTwoCircleCollisions(double aX, double aY, double aR, double aMass, double aViX, double aViY,
            double bX, double bY, double bR, double bMass, double bViX, double bViY)
        {
            Eng_Vector2D CircleA = new Eng_Vector2D(aViX, aViY);
            Eng_Vector2D CircleB = new Eng_Vector2D(bViX, bViY);

            Eng_Vector2D CenterAB = new Eng_Vector2D(aX - bX, aY - bY);

            double VectorCircle = Math.Sqrt((Math.Pow(CenterAB.x,2) + (Math.Pow(CenterAB.y,2))));

            Eng_Vector2D N = new Eng_Vector2D(CenterAB.x / VectorCircle, CenterAB.y / VectorCircle);
            
            double a1 = DotProductofTwo2DVectors(CircleA, N);
            double a2 = DotProductofTwo2DVectors(CircleB, N);

            double optimized = (2 * (a1 - a2)) / (aMass + bMass);

            //𝑉𝐴𝑓 = 𝑉𝐴𝑖 − (𝑜𝑝𝑡𝑖𝑚𝑖𝑧𝑒𝑑 × 𝑚𝐵) × N
            Eng_Vector2D VAf = new Eng_Vector2D(aViX - (optimized * bMass) * N.x, aViY - (optimized * bMass) * N.y);
            Eng_Vector2D VBf = new Eng_Vector2D(bViX + (optimized * aMass) * N.x, bViY + (optimized * aMass) * N.y);

            return new Tuple<Eng_Vector2D, Eng_Vector2D>(VAf, VBf);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aX"></param>
        /// <param name="aY"></param>
        /// <param name="aZ"></param>
        /// <param name="aR"></param>
        /// <param name="aMass"></param>
        /// <param name="aViX"></param>
        /// <param name="aViY"></param>
        /// <param name="aViZ"></param>
        /// <param name="bX"></param>
        /// <param name="bY"></param>
        /// <param name="bZ"></param>
        /// <param name="bR"></param>
        /// <param name="bMass"></param>
        /// <param name="bViX"></param>
        /// <param name="bViY"></param>
        /// <param name="bViZ"></param>
        /// <returns></returns>
        public static Tuple<Eng_Vector3D, Eng_Vector3D> FinalVelocityOfTwoSphereCollisions(double aX, double aY, double aZ, double aR, double aMass, double aViX, double aViY, double aViZ,
            double bX, double bY, double bZ, double bR, double bMass, double bViX, double bViY, double bViZ)
        {
            Eng_Vector3D CircleA = new Eng_Vector3D(aViX, aViY, aViZ);
            Eng_Vector3D CircleB = new Eng_Vector3D(bViX, bViY, bViZ);

            Eng_Vector3D CenterAB = new Eng_Vector3D(aX - bX, aY - bY, aZ - bZ);

            double VectorCircle = Math.Sqrt((Math.Pow(CenterAB.x, 2) + (Math.Pow(CenterAB.y, 2)) + (Math.Pow(CenterAB.z, 2))));

            Eng_Vector3D N = new Eng_Vector3D(CenterAB.x / VectorCircle, CenterAB.y / VectorCircle, CenterAB.z / VectorCircle);

            double a1 = DotProductofTwo3DVectors(CircleA, N);
            double a2 = DotProductofTwo3DVectors(CircleB, N);

            double optimized = (2 * (a1 - a2)) / (aMass + bMass);

            //𝑉𝐴𝑓 = 𝑉𝐴𝑖 − (𝑜𝑝𝑡𝑖𝑚𝑖𝑧𝑒𝑑 × 𝑚𝐵) × N
            Eng_Vector3D VAf = new Eng_Vector3D(aViX - (optimized * bMass) * N.x, aViY - (optimized * bMass) * N.y, aViZ - (optimized * bMass) * N.z);

            Eng_Vector3D VBf = new Eng_Vector3D(bViX + (optimized * aMass) * N.x, bViY + (optimized * aMass) * N.y, bViZ + (optimized * aMass) * N.z);

            return new Tuple<Eng_Vector3D, Eng_Vector3D>(VAf, VBf);

        }
        #endregion
    }
}
