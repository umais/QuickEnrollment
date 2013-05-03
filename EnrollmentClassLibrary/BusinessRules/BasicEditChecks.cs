using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentClassLibrary.BusinessRules
{
    /// <summary>
    /// The class <c>BasicEditChecks</c> contains methods for checking the content and format
    /// of incoming data.
    /// </summary>
    class BasicEditChecks
    {

        /// <summary>
        /// CheckLength compares the length of a string to verify that is equal to a specified amount.
        /// </summary>
        /// <param name="TheData">The string that is being measured.</param>
        /// <param name="TheLength">The length being compared.</param>
        /// <returns>If the length of the string equals the parameter then true, otherwise false.</returns>
        public bool CheckLength(string TheData, int TheLength)
        {
            bool Result = true;
            if (TheData.Length != TheLength) Result = false;
            return Result;
        }

        /// <summary>
        /// MaxLength compares the length of a string to verify that it is not longer than a specified
        /// amount.
        /// </summary>
        /// <param name="TheData">The string that is being measured.</param>
        /// <param name="TheLength">The length being compared</param>
        /// <returns></returns>
        public bool MaxLength(string TheData, int TheLength)
        {
            bool Result = true;
            if (TheData.Length > TheLength) Result = false;
            return Result;
        }

        /// <summary>
        /// MinLength compare the length of a string to verify that it is not shorter than a
        /// specified amount.
        /// </summary>
        /// <param name="TheData">The string that is being measured.</param>
        /// <param name="TheLength">The length being compared.</param>
        /// <returns></returns>
        public bool MinLength(string TheData, int TheLength)
        {
            bool Result = true;
            if (TheData.Length < TheLength) Result = false;
            return Result;
        }

        /// <summary>
        /// CheckRequired verifies that an incoming string contains data.
        /// </summary>
        /// <param name="TheData">The string that is being verified.</param>
        /// <returns>If the string contains data then return true, otherwise false.</returns>
        public bool CheckRequired(string TheData)
        {
            bool Result = true;
            if (TheData.Trim().Length < 1) Result = false;
            return Result;
        }

        /// <summary>
        /// CheckIsDate verifies that an incoming string contains a date in the format
        /// YYYYMMDD.
        /// </summary>
        /// <param name="TheData">The string being verified.</param>
        /// <returns>If the string is a properly formatted date then true, otherwise false.</returns>
        public bool CheckIsDate(string TheData)
        {
            bool Result = true;
            CultureInfo enUS = new CultureInfo("en-US");
            DateTime ResultDate;
            Result = DateTime.TryParseExact(TheData, "yyyyMMdd", enUS, DateTimeStyles.None, out ResultDate);

            return Result;
        }

        /// <summary>
        /// CheckIsInt verifies that an incoming string contains an integer.
        /// </summary>
        /// <param name="TheData">The string being verified.</param>
        /// <returns>If the string is an integer then true, otherwise false.</returns>
        public bool CheckIsInt(string TheData)
        {
            int ResultInt;
            return int.TryParse(TheData, out ResultInt);
        }

        /// <summary>
        /// CheckInList compares the string data against a list of vaues passed as an array.
        /// </summary>
        /// <param name="TheData">The string being verified.</param>
        /// <param name="TheValues">An array of strings. The input string is compared against this array.</param>
        /// <returns>If a value in the array matches the input string, then true otherwise false.</returns>
        public bool CheckInList(string TheData, string[] TheValues)
        {
            // this method initializes Result to false, when a match is found then result is true.
            bool Result = false;
            for (int i = 0; i <= TheValues.Length; i++)
            {
                if (TheData == TheValues[i])
                {
                    Result = true;
                    break;
                }
            }
            return Result;
        }
    }

}
