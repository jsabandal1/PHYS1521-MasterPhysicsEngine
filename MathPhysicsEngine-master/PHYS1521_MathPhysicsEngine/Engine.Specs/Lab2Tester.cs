    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Classes;
using Xunit;

namespace Engine.Specs
{
    /// <summary>
    /// Test Class for lab 2
    /// </summary>
    public class Lab2Tester
    {
        #region Matrix Multiplication
        /// <summary>
        /// 4x4 matrix multiplication data
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Object[]> MatrixMultiplicationData()
        {
            // Instructor Data
            yield return new Object[]
            {
                // Test Datais:
                //   Matrix A
                //   Matrix B
                //   Expected = A x B
                new Eng_Matrix4x4(
                    2, 0, 0, 0.5,
                    0, -2, 0, 1.5,
                    0, 0, 3, 2,
                    0, 0, 0, 1),
                new Eng_Matrix4x4(
                    3, 2, -1, 1,
                    0, 2, 3, -1,
                    2, 0, 2, 2,
                    0, 0, 0, 1),
                new Eng_Matrix4x4(
                    6, 4, -2, 2.5,
                    0, -4, -6, 3.5,
                    6, 0, 6, 8,
                    0, 0, 0, 1)
            };
            // Student Data

        }

        /// <summary>
        /// test data for MatrixVectorMultiplication
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Object[]> MatrixVectorMultiplicationData()
        {
            // Instructor Data
            yield return new Object[]
            {
                // Test Data is:
                //   Matrix M
                //   Vector V
                //   Expected = M x V
                new Eng_Matrix4x4(
                    2, 0, 0, 0.5,
                    0, -2, 0, 1.5,
                    0, 0, 3, 2,
                    0, 0, 0, 1),
                new Eng_Vector4D(-2, 3, -5, 1),
                new Eng_Vector4D(-3.5, -4.5, -13, 1)
            };
            // Student Data

        }

        /// <summary>
        /// transpose matrix data
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Object[]> TransposeMatrixData()
        {
            // Instructor Data
            yield return new Object[]
            {
                // Test Data is:
                //   Matrix M
                //   Expected = M^T
                new Eng_Matrix4x4(
                    2, 0, 0, 0.5,
                    0, -2, 0, 1.5,
                    0, 0, 3, 2,
                    0, 0, 0, 1),
               new Eng_Matrix4x4(
                   2, 0, 0, 0,
                   0, -2, 0, 0,
                   0, 0, 3, 0,
                   0.5, 1.5, 2, 1)
            };
            // Student Data

        }

        /// <summary>
        /// inverse matrix data
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Object[]> InverseMatrixData()
        {
            // Instructor Data
            yield return new Object[]
            {
                // Test Data is:
                //   Matrix M
                //   Expected = M^-1
                new Eng_Matrix4x4(
                    2, 0, 0, 0.5,
                    0, -2, 0, 1.5,
                    0, 0, 3, 2,
                    0, 0, 0, 1),
               new Eng_Matrix4x4(
                   0.5, 0, 0, -0.25,
                   0, -0.5, 0, 0.75,
                   0, 0, 0.3333, -0.6667,
                   0, 0, 0, 1)
            };
            // Student Data

        }

        /// <summary>
        /// multiply 2 4x4 matrix
        /// </summary>
        /// <param name="givenA"></param>
        /// <param name="givenB"></param>
        /// <param name="expected"></param>
        [Theory]
        [MemberData("MatrixMultiplicationData")]
        public void TestMultiplyMatrices4(Eng_Matrix4x4 givenA, Eng_Matrix4x4 givenB, Eng_Matrix4x4 expected)
        {
             Eng_Matrix4x4 result = Calculator.MultiplyTwo4x4Matrix(givenA, givenB);
            // Arrange - get data to do the test
            // This test uses [MemberData]
            // Act - performing the action

            // Assert - did we get back the correct answer
            Assert.Equal(expected.m11, result.m11);
            Assert.Equal(expected.m12, result.m12);
            Assert.Equal(expected.m13, result.m13);
            Assert.Equal(expected.m14, result.m14);
            
            Assert.Equal(expected.m21, result.m21);
            Assert.Equal(expected.m22, result.m22);
            Assert.Equal(expected.m23, result.m23);
            Assert.Equal(expected.m24, result.m24);

            Assert.Equal(expected.m31, result.m31);
            Assert.Equal(expected.m32, result.m32);
            Assert.Equal(expected.m33, result.m33);
            Assert.Equal(expected.m34, result.m34);

            Assert.Equal(expected.m41, result.m41);
            Assert.Equal(expected.m42, result.m42);
            Assert.Equal(expected.m43, result.m43);
            Assert.Equal(expected.m44, result.m44);

        }

        /// <summary>
        /// multiplyvector4x4 test
        /// </summary>
        /// <param name="givenM"></param>
        /// <param name="givenV"></param>
        /// <param name="expected"></param>
        [Theory]
        [MemberData("MatrixVectorMultiplicationData")]
        public void TestMultiplyVector4ByMatrix(Eng_Matrix4x4 givenM, Eng_Vector4D givenV, Eng_Vector4D expected)
        {
            Eng_Vector4D result = Calculator.MultiplyVectorMatrix(givenV, givenM);
            Assert.Equal(expected.x, result.x);
            Assert.Equal(expected.y, result.y);
            Assert.Equal(expected.z, result.z);
            Assert.Equal(expected.w, result.w);
        }

        /// <summary>
        /// test transpose matrix
        /// </summary>
        /// <param name="given"></param>
        /// <param name="expected"></param>
        [Theory]
        [MemberData("TransposeMatrixData")]
        public void TestTranposeMatrix(Eng_Matrix4x4 given, Eng_Matrix4x4 expected)
        {
            // Arrange - get data to do the test
            // This test uses [MemberData]
            // Act - performing the action
            Eng_Matrix4x4 result = Calculator.TransposeMatrix(given);

            Assert.Equal(expected.m11, result.m11);
            Assert.Equal(expected.m12, result.m12);
            Assert.Equal(expected.m13, result.m13);
            Assert.Equal(expected.m14, result.m14);

            Assert.Equal(expected.m21, result.m21);
            Assert.Equal(expected.m22, result.m22);
            Assert.Equal(expected.m23, result.m23);
            Assert.Equal(expected.m24, result.m24);

            Assert.Equal(expected.m31, result.m31);
            Assert.Equal(expected.m32, result.m32);
            Assert.Equal(expected.m33, result.m33);
            Assert.Equal(expected.m34, result.m34);

            Assert.Equal(expected.m41, result.m41);
            Assert.Equal(expected.m42, result.m42);
            Assert.Equal(expected.m43, result.m43);
            Assert.Equal(expected.m44, result.m44);
        }

        /// <summary>
        /// test determinant4x4
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
        /// <param name="m44"></param>
        /// <param name="expected"></param>
        [Theory]
        // Instructor Data
        [InlineData(2, 0, 0, 0.5, 0, -2, 0, 1.5, 0, 0, 3, 2, 0, 0, 0, 1, -12)]
        // Student Data
        public void TestDeterminant4(
            double m11, double m12, double m13, double m14,
            double m21, double m22, double m23, double m24,
            double m31, double m32, double m33, double m34,
            double m41, double m42, double m43, double m44,
            double expected)
        {
            Eng_Matrix4x4 givenMatrix = new Eng_Matrix4x4(
             m11, m12, m13, m14,
             m21, m22, m23, m24,
             m31, m32, m33, m34,
             m41, m42, m43, m44);
            double result = Calculator.CalculateDeterminant4x4(givenMatrix);
            Assert.Equal(expected, result);     
        }

        /// <summary>
        /// test inverse 
        /// </summary>
        /// <param name="given"></param>
        /// <param name="expected"></param>
        [Theory]
        [MemberData("InverseMatrixData")]
        public void TestInverse4(Eng_Matrix4x4 given, Eng_Matrix4x4 expected)
        {
            Eng_Matrix4x4 result = Calculator.InverseOfA4x4Matrix(given);

            Assert.Equal(expected.m11, result.m11);
            Assert.Equal(expected.m12, result.m12);
            Assert.Equal(expected.m13, result.m13);
            Assert.Equal(expected.m14, result.m14);

            Assert.Equal(expected.m21, result.m21);
            Assert.Equal(expected.m22, result.m22);
            Assert.Equal(expected.m23, result.m23);
            Assert.Equal(expected.m24, result.m24);

            Assert.Equal(expected.m31, result.m31);
            Assert.Equal(expected.m32, result.m32);
            Assert.Equal(expected.m33, result.m33);
            Assert.Equal(expected.m34, result.m34);

            Assert.Equal(expected.m41, result.m41);
            Assert.Equal(expected.m42, result.m42);
            Assert.Equal(expected.m43, result.m43);
            Assert.Equal(expected.m44, result.m44);
            // Arrange - get data to do the test
            // This test uses [MemberData]
            // Act - performing the action

            // Assert - did we get back the correct answer

        }
        #endregion

        #region 2D Rotation

        /// <summary>
        /// testrotation
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <param name="x3"></param>
        /// <param name="y3"></param>
        /// <param name="degrees"></param>
        /// <param name="expectedx1"></param>
        /// <param name="expectedy1"></param>
        /// <param name="expectedx2"></param>
        /// <param name="expectedy2"></param>
        /// <param name="expectedx3"></param>
        /// <param name="expectedy3"></param>
        [Theory]
        // Instructor Data
        [InlineData(3, -1, -4, 5, 2, 3, 25, 3.1415, 0.3615, -5.7383, 2.8411, 0.5448, 3.5642)]
        // Student Data
        public void TestRotation2D(
            double x1, double y1, double x2, double y2, double x3, double y3, double degrees,
            double expectedx1, double expectedy1,
            double expectedx2, double expectedy2,
            double expectedx3, double expectedy3)
        {
            // Arrange - get data to do the test
            Eng_Matrix3x3 m = Calculator.RotationMatrix(25);

            Eng_Vector3D first = new Eng_Vector3D(x1, y1, 1);
            Eng_Vector3D second = new Eng_Vector3D(x2, y2, 1);
            Eng_Vector3D third = new Eng_Vector3D(x3, y3, 1);


            Eng_Vector3D result1 = Calculator.MultiplyVectorMatrix3x3(first, m);
            Eng_Vector3D result2 = Calculator.MultiplyVectorMatrix3x3(second, m);
            Eng_Vector3D result3 = Calculator.MultiplyVectorMatrix3x3(third, m);

            Assert.Equal(expectedx1, Math.Round(result1.x,4));
            Assert.Equal(expectedy1, Math.Round(result1.y, 4));

            Assert.Equal(expectedx2, Math.Round(result2.x, 4));
            Assert.Equal(expectedy2, Math.Round(result2.y, 4));

            Assert.Equal(expectedx3, Math.Round(result3.x, 4));
            Assert.Equal(expectedy3, Math.Round(result3.y, 4));
            // Act - performing the action

            // Assert - did we get back the correct answer

        }
        #endregion


        #region 3D Rotation
        /// <summary>
        /// test quaternion to matrix
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Object[]> QuaternionToMatrixData()
        {
            // Instructor Data
            yield return new Object[]
            {
                // Test Data is:
                //   Quaternion Q
                //   Expected = M
                new Eng_Quaternion(15, 10, 5),
                new Eng_Matrix4x4(
                    0.9662, -0.2432, 0.0858, 0,
                    0.2549, 0.9513, -0.1736, 0,
                    -0.0394, 0.1897, 0.9811, 0,
                    0, 0, 0, 1)

            };
            // Student Data

        }

        ///// <summary>
        ///// rotate 3D vector
        ///// </summary>
        ///// <returns></returns>
        //public static IEnumerable<Object[]> Rotate3DData()
        //{

        //    // Instructor Data
        //    yield return new Object[]
        //    {
        //        // Test Data is:
        //        //   Vector V
        //        //   Quaternion V
        //        //   Expected = Q x V, converting Q to Matrix R,
        //        //            = R x V 
        //        new Eng_Vector4D(-2, 5, 3, 1),
        //        new Eng_Quaternion(15, 10, 5),
        //        new Eng_Vector4D(-2.8909, 3.7255, 3.9703, 1)

        //    };
        //    // Student Data
        //}

        //[Theory]
        //// Instructor Data
        //[InlineData(15, 10, 5, 0.987228288176272, 0.0919996771632968, 0.0317163728481948, 0.126136585175556)]
        //// Student Data

        //public void TestQuaternion(
        //    double bank, double attitude, double heading,
        //    double expectedQw, double expectedQx, double expectedQy, double expectedQz)
        //{
        //    // Arrange - get data to do the test
        //    // Act - performing the action

        //    // Assert - did we get back the correct answer

        //}

        [Theory]
        [MemberData("QuaternionToMatrixData")]
        public void TestQuaternionToMatrix(Eng_Quaternion q, Eng_Matrix4x4 expected)
        {
            // Arrange - get data to do the test
            Eng_Matrix4x4 result = Calculator.QuaternionToMatrixConversion(q);

            // This method uses MemberData

            // Act - performing the action

            // Assert - did we get back the correct answer
            Assert.Equal(expected.m11, result.m11);
            Assert.Equal(expected.m12, result.m12);
            Assert.Equal(expected.m13, result.m13);
            Assert.Equal(expected.m14, result.m14);

            Assert.Equal(expected.m21, result.m21);
            Assert.Equal(expected.m22, result.m22);
            Assert.Equal(expected.m23, result.m23);
            Assert.Equal(expected.m24, result.m24);

            Assert.Equal(expected.m31, result.m31);
            Assert.Equal(expected.m32, result.m32);
            Assert.Equal(expected.m33, result.m33);
            Assert.Equal(expected.m34, result.m34);

            Assert.Equal(expected.m41, result.m41);
            Assert.Equal(expected.m42, result.m42);
            Assert.Equal(expected.m43, result.m43);
            Assert.Equal(expected.m44, result.m44);
        }

        //[Theory]
        //[MemberData("Rotate3DData")]
        //public void TestRotate3D(Eng_Vector4D v, Eng_Quaternion q, Eng_Vector4D expected)
        //{
        //    // Arrange - get data to do the test
        //    // This method uses MemberData
        //    // Act - performing the action

        //    // Assert - did we get back the correct answer

        //}

        //[Theory]
        //// Instructor Data
        //[InlineData(0.987228288176272, 0.0919996771632968, 0.0317163728481948, 0.126136585175556, 15, 10, 5)]
        //// Student Data

        //public void TestQuaterionToEuler(double qW, double qX, double qY, double qZ,
        //    double expectedRoll, double expectedPitch, double expectedYaw)
        //{
        //    // Arrange - get data to do the test

        //    // Act - performing the action

        //    // Assert - did we get back the correct answer

        //}
        #endregion
    }
}

