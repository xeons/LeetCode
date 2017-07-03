using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P008_String_to_Integer
{
    class Solution
    {
        /*
         * 1047 / 1047 test cases passed.
         * Status: Accepted
         * Runtime: 166 ms
         */
        public int MyAtoi(string str)
        {
            string input = str.Trim();

            if (input.Length == 0)
                return 0;

            int sign = 1;
            int output = 0;
            int start = 0;

            // sanity checks
            if (input[0] == '+' || input[0] == '-')
            {
                if (input.Length < 2 || (input[1] < '0' || input[1] > '9'))
                    return 0;

                sign = input[0] == '-' ? -1 : 1;
                start = 1;
            }
            else if (!(input[0] >= '0' && input[0] <= '9'))
            {
                return 0;
            }

            for(int i = start; i < input.Length; i++)
            {
                int digit = input[i] - '0';
                if (digit < 0 || digit > 9)
                    break;

                if (int.MaxValue / 10 < output || int.MaxValue / 10 == output && int.MaxValue % 10 < digit)
                    return sign == 1 ? int.MaxValue : int.MinValue;

                output = 10 * output + digit;
            }

            return output * sign;
        }
    }
}
