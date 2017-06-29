using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P007_Reverse_Integer
{
    class Solution
    {
        /*
         * 1032 / 1032 test cases passed.
         * Status: Accepted
         * Runtime: 82 ms
         */
        public int Reverse(int x)
        {
            long temp = Math.Abs((long)x), carry = 0;
            long output = 0;
            int digits = (int)Math.Floor(Math.Log10(temp) + 1);

            while (temp > 0)
            {
                carry = temp % 10;
                temp = temp / 10;
                output = output + (long)Math.Pow(10, --digits) * carry;
            }

            return x > 0 ? (output > int.MaxValue ? 0 : (int)output) : (-output < int.MinValue ? 0 : (int)-output);
        }
    }
}
