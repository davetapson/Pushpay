using System;

namespace Pushpay
{
    class Program
    {
        static void Main(string[] args)
        {
            Util util = new Util();

            Console.WriteLine("Palindrome Batch Test: \n");

            util.Check("abcba", true);
            util.Check("abcde", false);
            util.Check("Mr owl ate my metal worm", true);
            util.Check("Never Odd Or Even", true);
            util.Check("Never Even Or Odd", false);

            string inputString;

            while (true)
            {
                Console.WriteLine("\nEnter text or \"Quit\" to Quit:");
                inputString = Console.ReadLine();

                if (inputString.ToLower() == "quit") break;

                string result = util.IsPalindrome(inputString) ? " is " : " is not ";

                Console.WriteLine($"{inputString}{result}a palindrome.");
            }
        } 
    }
}
