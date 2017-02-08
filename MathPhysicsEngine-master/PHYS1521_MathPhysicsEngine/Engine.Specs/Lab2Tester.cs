    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Classes;
using Xunit;

namespace Engine.Specs
{
    public class Lab2Tester
    {
        #region Matrix Multiplication
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

        [Theory]
        [MemberData("MatrixMultiplicationData")]
        public void TestMultiplyMatrices4(Eng_Matrix4x4 givenA, Eng_Matrix4x4 givenB, Eng_Matrix4x4 expected)
        {
            // Arrange - get data to do the test
            // This test uses [MemberData]
            // Act - performing the action
            
            // Assert - did we get back the correct answer
            
        }

        [Theory]
        [MemberData("MatrixVectorMultiplicationData")]
        public void TestMultiplyVector4ByMatrix(Eng_Matrix4x4 givenM, Eng_Vector4D givenV, Eng_Vector4D expected)
        {
            // Arrange - get data to do the test
            // This test uses [MemberData]
            // Act - performing the action
            
            // Assert - did we get back the correct answer
            
        }

        [Theory]
        [MemberData("TransposeMatrixData")]
        public void TestTranposeMatrix(Eng_Matrix4x4 given, Eng_Matrix4x4 expected)
        {
            // Arrange - get data to do the test
            // This test uses [MemberData]
            // Act - performing the action
            
            // Assert - did we get back the correct answer
            
        }

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
            // Arrange - get data to do the test
           
            // Act - performing the action
           
            // Assert - did we get back the correct answer
            
        }

        [Theory]
        [MemberData("InverseMatrixData")]
        public void TestInverse4(Eng_Matrix4x4 given, Eng_Matrix4x4 expected)
        {
            // Arrange - get data to do the test
            // This test uses [MemberData]
            // Act - performing the action
            
            // Assert - did we get back the correct answer
           
        }
        #endregion

        #region 2D Rotation
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
           
            // Act - performing the action
            
            // Assert - did we get back the correct answer
            
        }
        #endregion

        #region 3D Rotation
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

        public static IEnumerable<Object[]> Rotate3DData()
        {

            // Instructor Data
            yield return new Object[]
            {
                // Test Data is:
                //   Vector V
                //   Quaternion V
                //   Expected = Q x V, converting Q to Matrix R,
                //            = R x V 
                new Eng_Vector4D(-2, 5, 3, 1),
                new Eng_Quaternion(15, 10, 5),
                new Eng_Vector4D(-2.8909, 3.7255, 3.9703, 1)

            };
            // Student Data
        }

        [Theory]
        // Instructor Data
        [InlineData(15, 10, 5, 0.987228288176272, 0.0919996771632968, 0.0317163728481948, 0.126136585175556)]
        // Student Data

        public void TestQuaternion(
            double bank, double attitude, double heading,
            double expectedQw, double expectedQx, double expectedQy, double expectedQz)
        {
            // Arrange - get data to do the test
            // Act - performing the action
            
            // Assert - did we get back the correct answer
            
        }

        [Theory]
        [MemberData("QuaternionToMatrixData")]
        public void TestQuaternionToMatrix(Eng_Quaternion q, Eng_Matrix4x4 expected)
        {
            // Arrange - get data to do the test
            // This method uses MemberData
            // Act - performing the action
            
            // Assert - did we get back the correct answer
            
        }

        [Theory]
        [MemberData("Rotate3DData")]
        public void TestRotate3D(Eng_Vector4D v, Eng_Quaternion q, Eng_Vector4D expected)
        {
            // Arrange - get data to do the test
            // This method uses MemberData
            // Act - performing the action
           
            // Assert - did we get back the correct answer
            
        }

        [Theory]
        // Instructor Data
        [InlineData(0.987228288176272, 0.0919996771632968, 0.0317163728481948, 0.126136585175556, 15, 10, 5)]
        // Student Data

        public void TestQuaterionToEuler(double qW, double qX, double qY, double qZ,
            double expectedRoll, double expectedPitch, double expectedYaw)
        {
            // Arrange - get data to do the test
           
            // Act - performing the action
            
            // Assert - did we get back the correct answer
           
        }
        #endregion
    }
}

