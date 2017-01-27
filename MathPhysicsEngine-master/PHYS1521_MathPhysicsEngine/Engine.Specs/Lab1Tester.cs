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
    /// Test Calculator
    /// </summary>
    public class Lab1Tester
    {

        #region Trig Test
        /// <summary>
        /// Test Data for Adjacent opposite looking for angle and hypotenuse
        /// </summary>
        /// <param name="degrees"></param>
        /// <param name="hypotenuse"></param>
        /// <param name="adjacent"></param>
        /// <param name="opposite"></param>
        [Theory]
        // Instructor Data
        [InlineData(25, 6, 5.4378, 2.5357)]
        // Student Data
        [InlineData(38.6598, 6.4031, 5, 4)]
        public void TestCalculateAdjacentOpposite(double degrees, double hypotenuse, double adjacent, double opposite)
        {


            // Arrange - get data to do the test
            Tuple<double, double> expected = new Tuple<double, double>(Math.Round(adjacent,4), Math.Round(opposite,4));
            // Act - performing the action
            Tuple<double, double> results = Calculator.AdjAndOpp(Math.Round(degrees,4), Math.Round(hypotenuse,4));
            // Assert - did we get back the correct answer
            Assert.Equal(expected, results);

        }

        /// <summary>
        /// Test for solving the adjacent and hypotenuse
        /// </summary>
        /// <param name="degrees"></param>
        /// <param name="opposite"></param>
        /// <param name="adjacent"></param>
        /// <param name="hypotenuse"></param>
        [Theory]
        // Instructor Data
        [InlineData(25, 6, 12.867, 14.1972)]
        // Student Data
        [InlineData(70.0169, 4, 11, 11.7047)]
        public void TestCalculateAdjacentHypotenuse(double degrees, double opposite, double adjacent, double hypotenuse)
        {
            // Arrange - get data to do the test
            Tuple<double, double> expected = new Tuple<double, double>(Math.Round(adjacent, 4), Math.Round(hypotenuse, 4));
            // Act - performing the action
            Tuple<double, double> results = Calculator.AdjAndHypo(Math.Round(degrees, 4), Math.Round(opposite, 4));
            // Assert - did we get back the correct answer
            Assert.Equal(expected, results);

        }
        /// <summary>
        /// Test the calculation for the opposite and hypotenuse
        /// </summary>
        /// <param name="degrees"></param>
        /// <param name="adjacent"></param>
        /// <param name="opposite"></param>
        /// <param name="hypotenuse"></param>
        [Theory]
        // Instructor Data
        [InlineData(25, 6, 2.7978, 6.6203)]
        // Student Data
        [InlineData(70.0169, 4, 11, 11.7047)]
        public void TestCalculateOppositeHypotenuse(double degrees, double adjacent, double opposite, double hypotenuse)
        {
            // Arrange - get data to do the test
            Tuple<double, double> expected = new Tuple<double, double>(Math.Round(opposite, 4), Math.Round(hypotenuse, 4));
            // Act - performing the action
            Tuple<double, double> results = Calculator.OppAndHypo(Math.Round(degrees, 4), Math.Round(adjacent, 4));
            // Assert - did we get back the correct answer
            Assert.Equal(expected, results);

        }

        /// <summary>
        /// test for calculating the hypotenuse and angle
        /// </summary>
        /// <param name="adjacent"></param>
        /// <param name="opposite"></param>
        /// <param name="hypotenuse"></param>
        /// <param name="degrees"></param>
        [Theory]
        // Instructor Data
        [InlineData(3, 4, 5, 53.1301)]
        // Student Data
        [InlineData(8, 9, 12.0416,48.3664)]
        public void TestCalculateHypotenuseTheta(double adjacent, double opposite, double hypotenuse, double degrees)
        {
            // Arrange - get data to do the test
            Tuple<double, double> expected = new Tuple<double, double>(Math.Round(hypotenuse, 4), Math.Round(degrees, 4));
            // Act - performing the action
            Tuple<double, double> results = Calculator.HypoTheta(Math.Round(opposite, 4), Math.Round(adjacent, 4));
            // Assert - did we get back the correct answer
            Assert.Equal(expected, results);

        }

        /// <summary>
        /// test for Calculating the adjacent and angle theta
        /// </summary>
        /// <param name="opposite"></param>
        /// <param name="hypotenuse"></param>
        /// <param name="adjacent"></param>
        /// <param name="degrees"></param>
        [Theory]
        // Instructor Data
        [InlineData(3, 4, 2.6458, 48.5904)]
        // Student Data
        [InlineData(5, 6.4031, 4, 51.3402)]
        public void TestCalculateAdjacentTheta(double opposite, double hypotenuse, double adjacent, double degrees)
        {
            // Arrange - get data to do the test
            Tuple<double, double> expected = new Tuple<double, double>(Math.Round(adjacent, 4), Math.Round(degrees, 4));
            // Act - performing the action
            Tuple<double, double> results = Calculator.AdjTheta(Math.Round(opposite, 4), Math.Round(hypotenuse, 4));
            // Assert - did we get back the correct answer
            Assert.Equal(expected, results);
        }

        /// <summary>
        /// Test for the calculation of opposite and theta
        /// </summary>
        /// <param name="adjacent"></param>
        /// <param name="hypotenuse"></param>
        /// <param name="opposite"></param>
        /// <param name="degrees"></param>
        [Theory]
        // Instructor Data
        [InlineData(3, 4, 2.6458, 41.4096)]
        // Student Data
        [InlineData(3, 7.6158, 7, 66.8014)]
        public void TestCalculateOppositeTheta(double adjacent, double hypotenuse, double opposite, double degrees)
        {
            // Arrange - get data to do the test
            Tuple<double, double> expected = new Tuple<double, double>(Math.Round(opposite, 4), Math.Round(degrees, 4));
            // Act - performing the action
            Tuple<double, double> results = Calculator.OppoTheta(Math.Round(adjacent, 4), Math.Round(hypotenuse, 4));
            // Assert - did we get back the correct answer
            Assert.Equal(expected, results);

        }
        #endregion

        /// <summary>
        /// test data for adding two 2D vector
        /// </summary>
        /// <returns></returns>
        // 2D vectors
        // Static method to set up Object-based test data
        public static IEnumerable<Object[]> AddVector2DData()
        {
            // Instructor Data
            yield return new Object[]
            {
        new Eng_Vector2D(3, 4),
        new Eng_Vector2D(6, 9),
        new Eng_Vector2D(9, 13)
            };
            // Student Data
            yield return new Object[]
            {
        new Eng_Vector2D(5, 1),
        new Eng_Vector2D(6, 2),
        new Eng_Vector2D(11, 3)
            };

        }


        /// <summary>
        /// test data for normalizing 2D vector
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Object[]> NormalizeVector2DData()
        {
            // Instructor Data
            yield return new Object[]
            {
        new Eng_Vector2D(3, 4),
        new Eng_Vector2D(0.6, 0.8)
            };
            // Student Data
            yield return new Object[]
            {
        new Eng_Vector2D(2, 3),
        new Eng_Vector2D(0.4, 0.6)
            };
        }

        /// <summary>
        /// test for adding two vectors
        /// </summary>
        /// <param name="givenA"></param>
        /// <param name="givenB"></param>
        /// <param name="expected"></param>
        [Theory]
        [MemberData("AddVector2DData")]
        public void TestAddVector(Eng_Vector2D givenA, Eng_Vector2D givenB, Eng_Vector2D expected)
        {
            // Arrange - get data to do the test
            // This test uses [MemberData]
            // Act - performing the action
            Eng_Vector2D result = Calculator.AddTwo2DVectors(givenA, givenB);
            // Assert - did we get back the correct answer
            Assert.Equal(expected, result);
        }

        /* IDK what this is
        /// <summary>
        /// test for normalize two vectors
        /// </summary>
        /// <param name="givenA"></param>
        /// <param name="expected"></param>
        [Theory]
        [MemberData("NormalizeVector2DData")]
        public void TestNormailze(Eng_Vector2D givenA, Eng_Vector2D expected)
        {
            // Arrange - get data to do the test
            // This test uses [MemberData]
            // Act - performing the action
            Eng_Vector2D result = Calculator.SurfaceNormalOfA2DVector(givenA);
            // Assert - did we get back the correct answer

        }
        */

        /// <summary>
        /// test for solving dot product of two 2D vectors
        /// </summary>
        /// <param name="givenAx"></param>
        /// <param name="givenAy"></param>
        /// <param name="givenBx"></param>
        /// <param name="givenBy"></param>
        /// <param name="expected"></param>
        [Theory]
        // Instructor Data
        [InlineData(3, 4, 6, 9, 54)]
        // Student Data
        [InlineData(4,5,2,8,48)]
        public void TestDotProduct(double givenAx, double givenAy, double givenBx, double givenBy, double expected)
        {
            // Arrange - get data to do the test
            Eng_Vector2D first = new Eng_Vector2D(givenAx, givenAy);
            Eng_Vector2D second = new Eng_Vector2D(givenBx, givenBy);
            // Act - performing the action
            double result = Calculator.DotProductofTwo2DVectors(first, second);
            // Assert - did we get back the correct answer
            Assert.Equal(expected, result);

        }

        /// <summary>
        /// Test for calculating the angle between two 2D vectors
        /// </summary>
        /// <param name="givenAx"></param>
        /// <param name="givenAy"></param>
        /// <param name="givenBx"></param>
        /// <param name="givenBy"></param>
        /// <param name="expected"></param>
        [Theory]
        // Instructor Data
        [InlineData(3, 4, 6, 9, 3.1798)]
        // Student Data
        [InlineData(3,1,4,2, 0.9899)]
        public void TestAngleBetweenVectors(double givenAx, double givenAy, double givenBx, double givenBy, double expected)
        {
            // Arrange - get data to do the test
            Eng_Vector2D first = new Eng_Vector2D(givenAx, givenAy);
            Eng_Vector2D second = new Eng_Vector2D(givenBx, givenBy);
            // Act - performing the action
            double result = Calculator.AngleBetweenTwo2DVectors(first, second);
            double newResult = Math.Round(result, 4);
            // Assert - did we get back the correct answer
            Assert.Equal(expected, newResult);

        }
        //3D Vectors
        // Static method to set up Object-based test data
        public static IEnumerable<Object[]> AddVector3DData()
        {
            // Instructor Data
            yield return new Object[]
            {
        new Eng_Vector3D(3, 4, 5),
        new Eng_Vector3D(6, 9, -2),
        new Eng_Vector3D(9, 13, 3)
            };
            // Student Data

        }

        public static IEnumerable<Object[]> NormalizeVector3DData()
        {
            // Instructor Data
            yield return new Object[]
            {
       new Eng_Vector3D(3, 4, 5),
       new Eng_Vector3D(0.4243, 0.5657, 0.7071)
            };
            // Student Data

        }

        public static IEnumerable<Object[]> CrossProductData()
        {
            // Instructor Data
            yield return new Object[]
            {
        new Eng_Vector3D(3, 4, 5),
        new Eng_Vector3D(6, 9, -1),
        new Eng_Vector3D(-49, 33, 3)
            };
            // Student Data

        }

        public static IEnumerable<Object[]> SurfaceNormalData()
        {
            // Instructor Data
            yield return new Object[]
            {
        new Eng_Vector3D(3, 4, 5),
        new Eng_Vector3D(6, 9, -1),
        new Eng_Vector3D(-0.8284, 0.5579, 0.0507)
            };
            // Student Data

        }

        [Theory]
        [MemberData("AddVector3DData")]
        public void TestAddVector(Eng_Vector3D givenA, Eng_Vector3D givenB, Eng_Vector3D expected)
        {
            // Arrange - get data to do the test
            // This test uses [MemberData]
            // Act - performing the action

            // Assert - did we get back the correct answer

        }

        [Theory]
        [MemberData("NormalizeVector3DData")]
        public void TestNormailze(Eng_Vector3D givenA, Eng_Vector3D expected)
        {
            // Arrange - get data to do the test
            // This test uses [MemberData]
            // Act - performing the action

            // Assert - did we get back the correct answer

        }

        [Theory]
        // Instructor Data
        [InlineData(3, 4, 5, 6, 9, -1, 49)]
        // Student Data

        public void TestDotProduct3D(double givenAx, double givenAy, double givenAz, double givenBx, double givenBy, double givenBz, double expected)
        {
            // Arrange - get data to do the test

            // Act - performing the action

            // Assert - did we get back the correct answer

        }

        [Theory]
        // Instructor Data
        [InlineData(3, 4, 5, 6, 9, -1, 50.3627)]
        // Student Data

        public void TestAngleBetweenVectors3D(double givenAx, double givenAy, double givenAz, double givenBx, double givenBy, double givenBz, double expected)
        {
            // Arrange - get data to do the test

            // Act - performing the action

            // Assert - did we get back the correct answer

        }

        [Theory]
        [MemberData("CrossProductData")]
        public void TestCrossProduct(Eng_Vector3D givenA, Eng_Vector3D givenB, Eng_Vector3D expected)
        {
            // Arrange - get data to do the test
            // This test uses [MemberData]
            // Act - performing the action

            // Assert - did we get back the correct answer

        }

        [Theory]
        [MemberData("SurfaceNormalData")]
        public void TestSurfaceNormal(Eng_Vector3D givenA, Eng_Vector3D givenB, Eng_Vector3D expected)
        {
            // Arrange - get data to do the test
            // This test uses [MemberData]
            // Act - performing the action

            // Assert - did we get back the correct answer

        }

    }
}
