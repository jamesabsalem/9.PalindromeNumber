using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(123));
        }
        public static bool IsPalindrome(int x)
        {
            int reverse = 0;
            int i = x;
            while (i > 0)
            {
                var reminder = i % 10;
                reverse = (reverse * 10) + reminder;
                i /= 10;
            }
            return x == reverse;
        }
    }
}
