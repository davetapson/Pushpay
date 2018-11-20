using System;
using System.Text.RegularExpressions;

namespace Pushpay
{
    public static class StringExtension
    {
        public static bool IsPalindrome(this string inputString)
        {
            // remove non-alphabetic chars and set to one case 
            string cleanString = inputString.AlphabeticOnly().ToLower();

            if (string.IsNullOrEmpty(cleanString)) return false;

            // couple of options to check for palindromity:
            // 1. loop in from both ends of the string checking if characters are equal
            // 2. split string in half, reverse the second string and check if equal - I 
            //    suspect this is faster particularly for longer strings

            int halfStringLength = cleanString.Length / 2;
            string frontOfString = cleanString.Substring(0, halfStringLength);

            // use char array to Reverse cleanString - if odd number of chars in string, this will 
            // exclude middle char, removing need to check for odd vs even length strings
            char[] charArray = cleanString.ToCharArray();
            Array.Reverse(charArray);

            string reversedString = new string(charArray);

            string backOfString = reversedString.Substring(0, halfStringLength);

            return frontOfString.Equals(backOfString);
        }

        public static string AlphabeticOnly(this string inputString)
        {
            return Regex.Replace(inputString, "[^a-zA-Z]", "");
        }
    }
}
