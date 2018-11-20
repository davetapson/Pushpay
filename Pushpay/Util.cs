using System;
using System.Text.RegularExpressions;

namespace Pushpay
{
    internal class Util
    {
        internal void Check(string s, bool shouldBePalindrome)
        {
            Console.WriteLine(IsPalindrome(s) == shouldBePalindrome ? "pass" : "FAIL");
        }

        internal bool IsPalindrome(string inputString)
        {
            string cleanString;

            // remove non alphabet chars and set to one case
            cleanString = Regex.Replace(inputString, "[^a-zA-Z]", "").ToLower();

            // couple of options to check for palindromity:
            // 1. loop in from both ends of the string checking if characters are equal
            // 2. split string in half, reverse the second string and check if equal - I 
            //    suspect this is faster particularly for longer strings

            string frontString = cleanString.Substring(0, cleanString.Length / 2);

            // use char array to Reverse cleanString - if odd number of chars in string, this will 
            // exclude middle char, removing need to check for odd vs even length strings
            char[] charArray = cleanString.ToCharArray();
            Array.Reverse(charArray);

            string tempString = new string(charArray);

            string backString = tempString.Substring(0, tempString.Length / 2);

            return frontString.Equals(backString);

        }
    


        /*
         * 


// Implement a palindrome checker to make the following test cases pass. This starter code is in C# but you are welcome to write your solution in any language
 
bool IsPalindrome(string s){
    return false; //todo
}
 
void Check(string s, bool shouldBePalindrome){
    Console.WriteLine(IsPalindrome(s) == shouldBePalindrome ? "pass" : "FAIL");  
}
 
void Main()
{
    Check("abcba", true);
    Check("abcde", false);
    Check("Mr owl ate my metal worm", true);
    Check("Never Odd Or Even", true);
    Check("Never Even Or Odd", false);
}
         * */

    }
}