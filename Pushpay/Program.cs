using System;

namespace Pushpay
{
    class Program
    {
        internal static void Check(string inputString, bool shouldBePalindrome)
        {
            Console.WriteLine(inputString.IsPalindrome() == shouldBePalindrome ? "pass" : "FAIL");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Palindrome checks: \n");

            Check("abcba", true);
            Check("abcde", false);
            Check("Mr owl ate my metal worm", true);
            Check("Never Odd Or Even", true);
            Check("Never Even Or Odd", false);

            string inputString;

            while (true)
            {
                Console.WriteLine("\nEnter text or \"Quit\" to Quit:");
                inputString = Console.ReadLine();

                if (inputString.ToLower() == "quit") break;

                string result = inputString.IsPalindrome() ? " is " : " is not ";

                Console.WriteLine($"\"{inputString}\"{result}a palindrome.");
            }
        } 
    }
}
