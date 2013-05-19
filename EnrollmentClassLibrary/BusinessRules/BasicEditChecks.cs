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
    public class BasicEditChecks
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
            if (TheData == null) return false;
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
            if (TheData == null) return true;
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
            if (TheData == null)
                if (TheLength == 0) return true;
                else
                    return false;
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
            if (TheData == null) return false;
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
            if (TheData == null) return false;
            CultureInfo enUS = new CultureInfo("en-US");
            DateTime ResultDate;
            Result = DateTime.TryParseExact(TheData, "yyyyMMdd", enUS, DateTimeStyles.None, out ResultDate);

            return Result;
        }

        /// <summary>
        /// CheckIsDatePrior verifies that an incoming string contains a date that is prior to a given date.
        /// </summary>
        /// <param name="TheData">String date being checked</param>
        /// <param name="CompareTo">Given that the "TheData" must be prior to: TheData less than CompareTo.</param>
        /// <returns>If the string is a date that is prior then true, otherwise false.</returns>
        public bool CheckIsDatePrior(string TheData, DateTime CompareTo)
        {
            bool Result = true;
            if (TheData == null) return false;
            if (!CheckIsDate(TheData)) return false;
            CultureInfo enUS = new CultureInfo("en-US");
            DateTime ResultDate = DateTime.ParseExact(TheData, "yyyyMMdd", enUS);
            Result = (ResultDate < CompareTo);

            return Result;
        }

        /// <summary>
        /// ConvertToDate is a simple method to convert a string into a DateTime variable. This is a simple
        /// but less efficient alternative to the ParseExact method.
        /// 
        /// If the string is not properly formatted, then an InvalidCaseException is thrown.
        /// </summary>
        /// <param name="TheData">A string in the format yyyMMdd</param>
        /// <returns>A DateTime representation of the string</returns>
        public DateTime ConvertToDate(string TheData)
        {
            if (!CheckIsDate(TheData)) throw new InvalidCastException();
            CultureInfo enUS = new CultureInfo("en-US");
            DateTime ResultDate = DateTime.ParseExact(TheData, "yyyyMMdd", enUS);
            return ResultDate;
        }

        /// <summary>
        /// CheckIsInt verifies that an incoming string contains an integer.
        /// </summary>
        /// <param name="TheData">The string being verified.</param>
        /// <returns>If the string is an integer then true, otherwise false.</returns>
        public bool CheckIsInt(string TheData)
        {
            int ResultInt;
            if (TheData == null) return false;
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
            if (TheData == null) return false;
            for (int i = 0; i < TheValues.Length; i++)
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
