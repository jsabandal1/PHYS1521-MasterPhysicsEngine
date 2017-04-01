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
    /// This is a test class that uses XUnit testing. Each method below is a sample of
    /// how the testing can be accomplished.
    /// </summary>
    public class EngineTester
    {
        #region Test Segment Length
        /// <summary>
        /// Tests the method in the Calculator class that calculates the length of
        /// a line segment between two Eng_Point2D points A and B.
        /// Note that there are two sets of data, one will be from the Instructor, which
        /// will give you a passed test if your method works. The other set of data is your
        /// student data and will pass if the student has calculated the expected answer
        /// correctly.
        /// </summary>
        /// <param name="aX">The x-component of point A</param>
        /// <param name="aY">The y-component of point A</param>
        /// <param name="bX">The x-component of point B</param>
        /// <param name="bY">The y-component of point B</param>
        /// <param name="expected">The expected value given the two Eng_Point2D points.</param>
        [Theory]
        // Instructor Data
        [InlineData(0, 0, 3, 4, 5)]
        // Student Data
        [InlineData(-1, -1, 2, 3, 5)]
        public void TestSegmentLength(double aX, double aY, double bX, double bY, double expected)
        {
            // Arrange - get data to do the test
            Eng_Point2D givenA = new Eng_Point2D(aX, aY);
            Eng_Point2D givenB = new Eng_Point2D(bX, bY);
            // Act - performing the action
            var actual = Calculator.SegmentLength(givenA, givenB);
            // Assert - did we get back the correct answer
            Assert.Equal(expected, actual);
        }
        #endregion

        #region Test MidPoint
        // Static method to set up Object-based test data
        /// <summary>
        /// This method holds object-based data to be used for the TestMidPoint test method.
        /// The TestMidPoint method returns a Eng_Point2D data type theefore this is the means
        /// to test this type of method.
        /// </summary>
        /// <returns>A List of Objects</returns>
        public static IEnumerable<Object[]> MidPointData()
        {
            // Instructor Data
            // 1st new Eng_Point2D is the point A
            // 2nd new Eng_Point2D is the point B
            // 3rd new Eng_Point2D is the expected outcome
            yield return new Object[]
            {
                new Eng_Point2D(3, 4),
                new Eng_Point2D(6, 9),
                new Eng_Point2D(4.5, 6.5)
            };

            // Student Data
            // 1st new Eng_Point2D is the point A
            // 2nd new Eng_Point2D is the point B
            // 3rd new Eng_Point2D is student expected outcome
            yield return new Object[]
            {
                new Eng_Point2D(3, 4),
                new Eng_Point2D(6, 9),
                new Eng_Point2D(4.5, 5.5)
            };
        }

        ///// <summary>
        ///// This test test the calcualtion of the midpoint, as a Eng_Point2D type, between
        ///// two Eng_Point2D points. The test data for this test comes from "MidPointData".
        ///// </summary>
        ///// <param name="givenA">Eng_Point2D: test point A</param>
        ///// <param name="givenB">Eng_Point2D: test point B</param>
        ///// <param name="expected">Expected, calculated, midpoint, a Eng_Point2D point, between test points A and B</param>
        //[Theory]
        //[MemberData("MidPointData")]
        //public void TestMidPoint(Eng_Point2D givenA, Eng_Point2D givenB, Eng_Point2D expected)
        //{
        //    // Arrange - get data to do the test
        //    // This test uses [MemberData]  
        //    // Act - performing the action
        //    Eng_Point2D actual = Calculator.MidPoint(givenA, givenB);
        //    // Assert - did we get back the correct answer
        //    Assert.Equal(expected.x, actual.x);
        //    Assert.Equal(expected.y, actual.y);
        //}
        #endregion


    }
}
