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
    }

}
