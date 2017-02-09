using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerGrid.Helpers
{
    public static class StringHelper
    {

        public static string TrimOuterStrings(string input, string openingString, string closingString)
        {
            string returnString = input.TrimStart(openingString);
            returnString = returnString.TrimEnd(closingString);

            return returnString;
        }

        public static string TrimStart(this string target, string trimString)
        {
            string result = target;
            while (result.StartsWith(trimString))
            {
                result = result.Substring(trimString.Length);
            }

            return result;
        }

        public static string TrimEnd(this string target, string trimString)
        {
            string result = target;
            while (result.EndsWith(trimString))
            {
                result = result.Substring(0, result.Length - trimString.Length);
            }

            return result;
        }

    }
}
