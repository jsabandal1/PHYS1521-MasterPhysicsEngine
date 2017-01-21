using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    /// <summary>
    /// This class contains some basic validation methods.
    /// </summary>
    internal class Validator
    {
        #region Valid Numbers
        /// <summary>
        /// Validates the the input string can be converted to a Double
        /// </summary>
        /// <param name="sArg">The text to be validated.</param>
        /// <returns>True: if the string can be parsed to a Double, False if not.</returns>
        public static Boolean IsDouble(string sArg)
        {
            double d;
            return Double.TryParse(sArg, out d);
        }

        /// <summary>
        /// Validates the the input string can be converted to a Float
        /// </summary>
        /// <param name="sArg">The text to be validated.</param>
        /// <returns>True: if the string can be parsed to a Float, False if not.</returns>
        public static Boolean IsFloat(string sArg)
        {
            float f;
            return float.TryParse(sArg, out f);
        }

        /// <summary>
        /// Validates the the input string can be converted to an Integer
        /// </summary>
        /// <param name="sArg">The text to be validated.</param>
        /// <returns>True: if the string can be parsed to an Integer, False if not.</returns>
        public static Boolean IsInteger(string sArg)
        {
            Int32 i;
            return Int32.TryParse(sArg, out i);
        }
        #endregion

        #region Valid Angles
        // angle validation for triangle
        /// <summary>
        /// Validates that the input angle, in degrees, is between 0 and 90.
        /// The values of 0 and 90 are invalid, as no triangle can have an
        /// angle on 0 degrees, and not right triangle can have two 90 degree
        /// angles.
        /// </summary>
        /// <param name="angle">The input angle in degrees (a double value)</param>
        /// <returns>True: if the angle is between 0 and 90, False if not</returns>
        public static Boolean ValidateTheta(double angle)
        {
            return (angle > 0 && angle < 90);
        }

        /// <summary>
        /// Validates that the input angle, in degrees, is between 0 and 90.
        /// The values of 0 and 90 are invalid, as no triangle can have an
        /// angle on 0 degrees, and not right triangle can have two 90 degree
        /// angles. 
        /// </summary>
        /// <param name="angle">The input angle in degrees (a double value)</param>
        /// <returns>True: if the angle is between 0 and 90, False if not</returns>
        public static Boolean ValidateIncline(double angle)
        {
            return (angle >= 0 && angle < 90);
        }

        // angle validation for PolarVector
        /// <summary>
        /// This validates that the angle is a positive angle from 0
        /// degrees to less than 360 degrees.
        /// </summary>
        /// <param name="angle">The input angle to be validated (a double value)</param>
        /// <returns>True: if the angle is from 0 to less than 360, False if not</returns>
        public static Boolean ValidateDirection(double angle)
        {
            return (angle >= 0 && angle < 360);
        }

        // angle validation for rotations
        /// <summary>
        /// This validates that the angle is a positive angle from 0
        /// degrees to less than 360 degrees. 
        /// </summary>
        /// <param name="angle">The input angle to be validated (a double value)</param>
        /// <returns>True: if the angle is from 0 to less than 360, False if not</returns>
        public static Boolean ValidateRotationAngle(double angle)
        {
            return (angle > -360 && angle < 360);
        }

        // angle for Euler Angles - NO GIMBAL LOCK
        /// <summary>
        /// THis validates the Euler angles are not 90 degrees to avoid Gimbal Lock.
        /// </summary>
        /// <param name="angle">The angle to be validated in degrees (a double value)</param>
        /// <returns>True: if the angle is not greater than or equal to the absolute value of 90.</returns>
        public static Boolean ValidateEuler(double angle)
        {
            return (angle > -90 && angle < 90);
        }
        #endregion
    }
}
