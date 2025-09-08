using System;
using System.Text;

namespace Homework1
{
    class PalindromeChecker
    {
        static void Main()
        {
            string input;

            do
            {
                Console.Write("Enter string: ");
                input = Console.ReadLine();

                if (input == "*")
                    break;

                string original = input;
                string lowered = input.ToLower();
                string reversed = ReverseString(lowered);
                string result = IsPalindrome(lowered, reversed) ? "Yes" : "No";

                Console.WriteLine("\nOriginal String         Reversed String            Palindrome?");
                Console.WriteLine($"  {original,-20} {reversed,-25} {result}\n");

            } while (true);
        }

        static string ReverseString(string s)
        {
            var sb = new StringBuilder(s.Length);
            for (int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }
            return sb.ToString();
        }

        static bool IsPalindrome(string original, string reversed)
        {
            return original == reversed;
        }
    }
}
