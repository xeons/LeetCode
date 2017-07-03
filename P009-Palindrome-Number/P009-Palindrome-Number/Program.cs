using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P009_Palindrome_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.IsPalindrome(123));
            Console.WriteLine(solution.IsPalindrome(123321));
            Console.WriteLine(solution.IsPalindrome(int.MaxValue));
            Console.ReadLine();
        }
    }
}
