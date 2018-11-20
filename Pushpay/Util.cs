using System;
using System.Text.RegularExpressions;

namespace Pushpay
{
    internal class Util
    {
        internal void Check(string inputString, bool shouldBePalindrome)
        {
            Console.WriteLine(IsPalindrome(inputString) == shouldBePalindrome ? "pass" : "FAIL");
        }

        internal bool IsPalindrome(string inputString)
        {
            // remove non alphabet chars and set to one case
            string cleanString = Regex.Replace(inputString, "[^a-zA-Z]", "").ToLower();

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
    }
}