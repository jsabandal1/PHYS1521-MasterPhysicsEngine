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
        [InlineData(10, 5, 0, -9.81, 1.53, 10.0000, -10.0093, 15.3, 7.65)]
        public static void TestCalculateVelcityDisplacement(
            double vIx, double vIy, double gX, double gY, double t,
            double vFx, double vFy, double dX, double dY)
        {
            // Tuple<int, string, bool> tuple = new Tuple<int, string, bool>(1, "cat", true);
            Tuple<double, double, double, double> expected = new Tuple<double, double, double, double>(vFx, vFy, dX, dY);

            Tuple<double, double, double, double> results = Calculator.VelocityFinalAndDisplacementXnY(gX, gY, t, vIx, vIy);

            Assert.Equal(expected.Item1, results.Item1);
            Assert.Equal(expected.Item2, Math.Round(results.Item2, 4));
            Assert.Equal(expected.Item3, results.Item3);
            Assert.Equal(expected.Item4, Math.Round(results.Item4, 2));

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
            Tuple<double, double, double> results = Calculator.DisplacementXnMaxHeightnTime(g, degrees, vI, h);
            Assert.Equal(distance, results.Item1);
            Assert.Equal(maxHeight, results.Item2);
            Assert.Equal(t, results.Item3);
           
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
        [InlineData(1500, 0.53, 157.0796, 13077.2258)]
        public void TestRotationalMotion1(
            double rpm, double radius, double omega /*rotational speed*/, double aT_Expected)
        {
            Tuple<double, double> results = Calculator.RadPerSecAndAcceleration(rpm, radius);
            // Arrange - get data to do the test
            Assert.Equal(omega, Math.Round(results.Item1, 4));
            Assert.Equal(aT_Expected, Math.Round(results.Item2, 4));          
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
        // Student Data
        [InlineData(0.15, 0.6, 3, 0.25, 14.3239, 0.0833, 0.0278, 0.05)]
        public static void TestRotationalMotion2(
            double arc, double radius, double t,
            double thetaR, double thetaD, double omega, double alpha, double vT)
        {
            // Arrange - get data to do the test .(theta,omega, alpha, vt)
            Tuple<double,double, double, double> results = Calculator.ChangeInThetaAngularVelocityAndAccelerationAndTangentialVelocity(arc, radius, t);
            // Act - performing the action
            double newThetaR = results.Item1;
            double newThetaD = Calculator.RadiansToDegree(newThetaR);
            // Assert - did we get back the correct answers
            Assert.Equal(thetaR, newThetaR);
            Assert.Equal(thetaD, Math.Round(newThetaD,4));
            Assert.Equal(omega, Math.Round(results.Item2,4));
            Assert.Equal(alpha, Math.Round(results.Item3,4));
            Assert.Equal(vT, Math.Round(results.Item4, 3));
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
        [InlineData(0.65, 0.15, 0.05, 0.0975, 0.0325)]
        public static void TestRotaionalMotion3(
            double omega, double aRadius, double bRadius,
            double vTa, double vTb)
        {
            // Arrange - get data to do the test
            Tuple<double, double> results = Calculator.TangentialVelocityOfTwoObjects(omega, aRadius, bRadius);

            // Act - performing the action
            Assert.Equal(vTa, results.Item1);
            Assert.Equal(vTb, results.Item2);
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
        // Student Data

        public static void TestCalculateNetForceNonIncline(
            double gX, double gY, double mass, double force, double forceAngle,
            double mu, double inclineDegrees, double netFx, double netFy,
            double aX, double aY, double t, double vFx, double vFy,
            double dX, double dY)
        {
            // Arrange - get data to do the test
            
            // Act - performing the action
            
            // Assert - did we get back the correct answers
            
        }

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
        [InlineData(0, -9.81, 100, 500, 0, 0.15, 10, 184.7367, 0, 1.8474, 0, 1.5, 2.7711, 0, 2.0783, 0)]// incline
        // Student Data

        public static void TestCalculateNetForceIncline(
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
        [InlineData(250000, 8700000000, 31000, 0.0001510278)]
        public static void TestCalculateGravitationalForce(
            double mass1, double mass2, double centersDistance,
            double expected)
        {
            // Arrange - get data to do the test
            double result =Calculator.ForceAttractionOfTwoObjects(mass1, mass2, centersDistance);
            // Act - performing the action
            Assert.Equal(expected, Math.Round(result,10));
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
        [InlineData(4.7e24, 6e6, -8.712)]
        public static void TestCalculateGravity(double mass, double radius, double expected)
        {
            // Arrange - get data to do the test
            double result = Calculator.surfaceGravityOfCelestialBody(mass, radius);
            // Act - performing the action
            Assert.Equal(expected, Math.Round(result, 4));
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
        [InlineData(0.2, 0.54, -9.81, 26.487)]
        public static void TestCalculateSpringConstant(
            double stretchedLength, double mass, double gravity, double expected)
        {
            // Arrange - get data to do the test
            double result = Calculator.CalculateSpringConstant(mass, stretchedLength, gravity);

            // Act - performing the action
            Assert.Equal(expected,Math.Round(result,3));
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
        [InlineData(21.315, 0.69, 0.2, 0.8846, 1.1116)]
        public static void TestCalculateSpringFreqVelocity(
            double k, double mass, double stretchedLength, double expectedFreq, double expectedVelocity)
        {
            // Arrange - get data to do the test
            Tuple<double, double> results = Calculator.SpringFreqAndVelocity(k, mass, stretchedLength);
            // Act - performing the action
            Assert.Equal(expectedFreq, Math.Round(results.Item1,4));
            Assert.Equal(expectedVelocity, Math.Round(results.Item2,4));
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
        [InlineData(7, 5122, 313, 35854, 114.5495)]
        public static void TestCalculateMomentum(
            double vI, double mass, double brakingForce, double p, double t)
        {
            // Arrange - get data to do the test
            Tuple<double, double> results = Calculator.CalculateTimeAndMomentum(mass, vI, brakingForce);

            Assert.Equal(p, results.Item1);
            Assert.Equal(t, Math.Round(results.Item2,4));
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
        [InlineData(1, -1, 3.5, 14, 2, 1, 3, 3, 4.5, 3, -3, -2, 1.2, -0.6, 0.6, 5.2)]
        public static void TestCircleCollision(
            double aX, double aY, double aR, double aMass, double aViX, double aViY,
            double bX, double bY, double bR, double bMass, double bViX, double bViY,
            double aVfX, double aVfY, double bVfX, double bVfY)
        {
            // Arrange - get data to do the test
            Tuple<Eng_Vector2D, Eng_Vector2D> Results = Calculator.FinalVelocityOfTwoCircleCollisions(aX, aY, aR, aMass, aViX, aViY,
             bX, bY, bR, bMass, bViX, bViY);

            Assert.Equal(aVfX, Math.Round(Results.Item1.x, 1));
            Assert.Equal(aVfY, Math.Round(Results.Item1.y, 1));

            Assert.Equal(bVfX, Math.Round(Results.Item2.x, 1));
            Assert.Equal(bVfY, Math.Round(Results.Item2.y, 1));
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
        [InlineData(4, -1, 2, 2.3, 7, 2, 3, 1, 5, -2, -3, 4.1, 2, -4, -5, 1, 2.0329, 2.9671, 0.8354, -4.1152, -4.8848, 1.5761)]
        public static void TestSphereCollision(
            double aX, double aY, double aZ, double aR, double aMass, double aViX, double aViY, double aViZ,
            double bX, double bY, double bZ, double bR, double bMass, double bViX, double bViY, double bViZ,
            double aVfX, double aVfY, double aVfZ, double bVfX, double bVfY, double bVfZ)
        {
            Tuple<Eng_Vector3D, Eng_Vector3D> Results = Calculator.FinalVelocityOfTwoSphereCollisions(aX, aY, aZ, aR, aMass, aViX, aViY, aViZ,
             bX, bY, bZ, bR, bMass, bViX, bViY, bViZ);

            Assert.Equal(aVfX, Math.Round(Results.Item1.x, 4));
            Assert.Equal(aVfY, Math.Round(Results.Item1.y, 4));
            Assert.Equal(aVfZ, Math.Round(Results.Item1.z, 4));

            Assert.Equal(bVfX, Math.Round(Results.Item2.x, 4));
            Assert.Equal(bVfY, Math.Round(Results.Item2.y, 4));
            Assert.Equal(bVfZ, Math.Round(Results.Item2.z, 4));


            // Assert - did we get back the correct answers

        }
        #endregion
    }
}
