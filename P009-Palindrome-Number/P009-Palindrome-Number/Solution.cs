using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P009_Palindrome_Number
{
    class Solution
    {
        /**
         * 11507 / 11507 test cases passed.
         * Status: Accepted
         * Runtime: 122 ms
         */
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            int y = x, reversed = 0;
            while (x > 0)
            {
                reversed = reversed * 10 + x % 10;
                x = x / 10;
            }

            return y == reversed;
        }
    }
}
