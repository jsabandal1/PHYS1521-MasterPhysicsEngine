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
    /// 
    /// </summary>
    public class Lab3Tester
    {
        #region Linear Motion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vIx"></param>
        /// <param name="vIy"></param>
        /// <param name="gX"></param>
        /// <param name="gY"></param>
        /// <param name="t"></param>
        /// <param name="vFx"></param>
        /// <param name="vFy"></param>
        /// <param name="dX"></param>
        /// <param name="dY"></param>
        [Theory]
        // Instructor Data
        [InlineData(3, -2, 0, -9.81, 2.5, 3, -26.525, 7.5, -5)]
        // Student Data
        [InlineData(10, 5, 0, -9.81, 1.53, 10, -10, 15.3, -3.82)]
        public static void TestCalculateVelcityDisplacement(
            double vIx, double vIy, double gX, double gY, double t,
            double vFx, double vFy, double dX, double dY)
        {
            // Tuple<int, string, bool> tuple = new Tuple<int, string, bool>(1, "cat", true);
            Tuple<double, double, double, double> expected = new Tuple<double, double, double, double>(vFx, vFy, dX, dY);

            Tuple<double, double, double, double> results = Calculator.VelocityFinalAndDisplacementXnY(gX, gY, t, vIx, vIy);

            Assert.Equal(expected.Item1, results.Item1);
            Assert.Equal(expected.Item2, Math.Round(results.Item2,1));
            Assert.Equal(expected.Item3, results.Item3);
            //Assert.Equal(expected.Item4, results.Item4);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vI"></param>
        /// <param name="degrees"></param>
        /// <param name="h"></param>
        /// <param name="g"></param>
        /// <param name="distance"></param>
        /// <param name="maxHeight"></param>
        /// <param name="t"></param>
        [Theory]
        // Instructor Data
        [InlineData(2.5, 5, 15, -9.81, 4.4109, 15.0024, 1.7711)]
        // Student Data

        public static void TestCalculateProjectile(
            double vI, double degrees, double h, double g,
            double distance, double maxHeight, double t)
        {
            // Arrange - get data to do the test
            
            // Act - performing the action
            
            // Assert - did we get back the correct answers
           
        }
        #endregion

        #region Rotational Motion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rpm"></param>
        /// <param name="radius"></param>
        /// <param name="omega"></param>
        /// <param name="aT_Expected"></param>
        [Theory]
        // Instructor Data
        [InlineData(3200, 0.25, 335.1032, 28073.5414)]
        // Student Data

        public void TestRotationalMotion1(
            double rpm, double radius, double omega, double aT_Expected)
        {
            // Arrange - get data to do the test

            // Act - performing the action
           
            // Assert - did we get back the correct answers
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arc"></param>
        /// <param name="radius"></param>
        /// <param name="t"></param>
        /// <param name="thetaR"></param>
        /// <param name="thetaD"></param>
        /// <param name="omega"></param>
        /// <param name="alpha"></param>
        /// <param name="vT"></param>
        [Theory]
        // Instructor Data
        [InlineData(0.25, 0.4, 2, 0.625, 35.8099, 0.3125, 0.1562, 0.125)]
        public static void TestRotationalMotion2(
            double arc, double radius, double t,
            double thetaR, double thetaD, double omega, double alpha, double vT)
        {
            // Arrange - get data to do the test

            // Act - performing the action
           
            // Assert - did we get back the correct answers
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="omega"></param>
        /// <param name="aRadius"></param>
        /// <param name="bRadius"></param>
        /// <param name="vTa"></param>
        /// <param name="vTb"></param>
        [Theory]
        // Instructor Data
        [InlineData(0.5, 0.25, 0.35, 0.125, 0.175)]
        // Student Data
        public static void TestRotaionalMotion3(
            double omega, double aRadius, double bRadius,
            double vTa, double vTb)
        {
            // Arrange - get data to do the test

            // Act - performing the action
           
            // Assert - did we get back the correct answers
            
        }
        #endregion

        #region Forces
        /// <summary>
        /// 
        /// </summary>
        /// <param name="gX"></param>
        /// <param name="gY"></param>
        /// <param name="mass"></param>
        /// <param name="force"></param>
        /// <param name="forceAngle"></param>
        /// <param name="mu"></param>
        /// <param name="inclineDegrees"></param>
        /// <param name="netFx"></param>
        /// <param name="netFy"></param>
        /// <param name="aX"></param>
        /// <param name="aY"></param>
        /// <param name="t"></param>
        /// <param name="vFx"></param>
        /// <param name="vFy"></param>
        /// <param name="dX"></param>
        /// <param name="dY"></param>
        [Theory]
        // Instructor Data
        [InlineData(0, -9.81, 100, 500, 10, 0.15, 0, 358.2775, 0, 3.5828, 0, 1.5, 5.3742, 0, 4.0306, 0)]// non-incline
        [InlineData(0, -9.81, 100, 500, 0, 0.15, 10, 184.7367, 0, 1.8474, 0, 1.5, 2.7711, 0, 2.0783, 0)]// incline
        // Student Data (two sets of data)

        public static void TestCalculateNetForce(
            double gX, double gY, double mass, double force, double forceAngle,
            double mu, double inclineDegrees, double netFx, double netFy,
            double aX, double aY, double t, double vFx, double vFy,
            double dX, double dY)
        {
            // Arrange - get data to do the test
            
            // Act - performing the action
            
            // Assert - did we get back the correct answers
            
        }
        #endregion

        #region Gravitational Forces
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mass1"></param>
        /// <param name="mass2"></param>
        /// <param name="centersDistance"></param>
        /// <param name="expected"></param>
        [Theory]
        // Instructor Data
        [InlineData(450000, 9500000000, 25000, 0.0004564332)]
        // Student Data

        public static void TestCalculateGravitationalForce(
            double mass1, double mass2, double centersDistance,
            double expected)
        {
            // Arrange - get data to do the test

            // Act - performing the action
           
            // Assert - did we get back the correct answer
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mass"></param>
        /// <param name="radius"></param>
        /// <param name="expected"></param>
        [Theory]
        // Instructor Data
        [InlineData(3.5e24, 5e6, -9.3422)]
        // Student Data

        public static void TestCalculateGravity(double mass, double radius, double expected)
        {
            // Arrange - get data to do the test

            // Act - performing the action

            // Assert - did we get back the correct answer
           
        }
        #endregion

        #region Springs
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stretchedLength"></param>
        /// <param name="mass"></param>
        /// <param name="gravity"></param>
        /// <param name="expected"></param>
        [Theory]
        // Instructor Data
        [InlineData(0.3, 0.75, -9.81, 24.525)]
        // Student Data

        public static void TestCalculateSpringConstant(
            double stretchedLength, double mass, double gravity, double expected)
        {
            // Arrange - get data to do the test

            // Act - performing the action
           
            // Assert - did we get back the correct answer
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="k"></param>
        /// <param name="mass"></param>
        /// <param name="stretchedLength"></param>
        /// <param name="expectedFreq"></param>
        /// <param name="expectedVelocity"></param>
        [Theory]
        // Instructor Data
        [InlineData(24.525, 0.75, 0.3, 0.9101, 1.7155)]
        // Student Data

        public static void TestCalculateSpringFreqVelocity(
            double k, double mass, double stretchedLength, double expectedFreq, double expectedVelocity)
        {
            // Arrange - get data to do the test

            // Act - performing the action
           
            // Assert - did we get back the correct answers
            
        }
        #endregion

        #region Impulse and Momentum
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vI"></param>
        /// <param name="mass"></param>
        /// <param name="brakingForce"></param>
        /// <param name="p"></param>
        /// <param name="t"></param>
        [Theory]
        // Instructor Data
        [InlineData(5, 1025, 105, 5125, 48.8095)]
        // Student Data

        public static void TestCalculateMomentum(
            double vI, double mass, double brakingForce, double p, double t)
        {
            // Arrange - get data to do the test

            // Act - performing the action
           
            // Assert - did we get back the correct answers
           
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
        /// <param name="aVfX"></param>
        /// <param name="aVfY"></param>
        /// <param name="bVfX"></param>
        /// <param name="bVfY"></param>
        [Theory]
        // Instructor Data
        [InlineData(3, -2, 1.5, 10, 1, 2, 4, -1, 2.5, 5, -2, -1, -1, 0, 2, 3)]
        // Student Data

        public static void TestCircleCollision(
            double aX, double aY, double aR, double aMass, double aViX, double aViY,
            double bX, double bY, double bR, double bMass, double bViX, double bViY,
            double aVfX, double aVfY, double bVfX, double bVfY)
        {
            // Arrange - get data to do the test
           
            // Act - performing the action
           
            // Assert - did we get back the correct answers
            
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
        /// <param name="aVfX"></param>
        /// <param name="aVfY"></param>
        /// <param name="aVfZ"></param>
        /// <param name="bVfX"></param>
        /// <param name="bVfY"></param>
        /// <param name="bVfZ"></param>
        [Theory]
        // Instructor Data
        [InlineData(3, -2, 4, 1.5, 10, 1, 2, 2, 4, -1, -2, 2.5, 5, -2, -1, 2, 0.8947, 1.8947, 2.6316, -1.7895, -0.7895, 0.7368)]
        // Student Data

        public static void TestSphereCollision(
            double aX, double aY, double aZ, double aR, double aMass, double aViX, double aViY, double aViZ,
            double bX, double bY, double bZ, double bR, double bMass, double bViX, double bViY, double bViZ,
            double aVfX, double aVfY, double aVfZ, double bVfX, double bVfY, double bVfZ)
        {
            // Arrange - get data to do the test
            
            // Act - performing the action
            
            // Assert - did we get back the correct answers
           
        }
        #endregion
    }
}
