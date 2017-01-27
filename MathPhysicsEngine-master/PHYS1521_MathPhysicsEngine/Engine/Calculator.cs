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
            return new Eng_Point2D(0.5 * (a.x + b.x), 0.5 * (a.y + b.y));
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

            adjacent = Math.Cos(DegreeToRadians(degreeAngle)) * hypotenuse;
            opposite = Math.Sin(DegreeToRadians(degreeAngle)) * hypotenuse;

            return new Tuple<double, double>(adjacent, opposite);
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

            adjacent = Math.Tan(DegreeToRadians(degreeAngle)) * opposite;
            hypotenuse = Math.Sin(DegreeToRadians(degreeAngle)) * adjacent;

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

            opposite = Math.Tan(DegreeToRadians(degreeAngle)) * adjacent;
            hypotenuse = adjacent / (Math.Cos(DegreeToRadians(degreeAngle)));

            return new Tuple<double, double>(opposite, hypotenuse);
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

            givenAngle = RadiansToDegree( (Math.Atan(sideOpp / sideAdj)) );
            hypotenuse = (sideOpp / (Math.Sin(DegreeToRadians(givenAngle))));

            return new Tuple<double, double>(hypotenuse, givenAngle);
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

            missingAngle = RadiansToDegree(Math.Asin(sideOpp / sideHypo));
            missingSide = Math.Cos(DegreeToRadians(missingAngle)) * sideHypo;

            return new Tuple<double, double>(missingAngle, missingSide);

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
            sideOpp = Math.Sin(DegreeToRadians(missingAngle) * sideHypo);

            return new Tuple<double, double>(sideOpp, missingAngle);
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
            return (first.x * second.x + first.y * second.y);
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
            angle = Math.Acos(DotProductofTwo2DVectors(first, second) / (first.magnitude * second.magnitude));

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
            return (first.x * second.x + first.y * second.y + first.z * second.z);
        }

        /// <summary>
        /// Solving the cross product of two 3D vectors
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static Eng_Vector3D CrossVectorProduct3D (Eng_Vector3D first, Eng_Vector3D second)
        {

            return new Eng_Vector3D ((first.x * second.z) - (first.z * second.y), (first.z * second.x) - (first.x * second.z), (first.x * second.y) - (first.y * second.x));
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
            angle = Math.Acos(DotProductofTwo3DVectors(first, second) / (first.magnitude * second.magnitude));

            return angle;
        }

        /// <summary>
        /// Surface normal of a 3D Vector
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public static double SurfaceNormalOfA3DVector(Eng_Vector3D first)
        {
            double topX = first.x / first.magnitude;
            double middleY = first.y / first.magnitude;
            double bottomZ = first.z / first.magnitude;

            Eng_Vector3D surfaceVector = new Eng_Vector3D(topX, middleY, bottomZ);

            return surfaceVector.magnitude;
        }
        #endregion
    }
}
