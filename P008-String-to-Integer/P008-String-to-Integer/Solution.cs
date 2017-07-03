using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P008_String_to_Integer
{
    class Solution
    {
        /*
         * 1047 / 1047 test cases passed.
         * Status: Accepted
         * Runtime: 205 ms
         * Your runtime beats 0.57 % of csharp submissions. :-(
         * This is an abomination...
         */
        public int MyAtoi(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return 0;

            Match match = Regex.Match(str.Trim(), @"^([\d+-]+)\D?");
            if (!match.Success)
                return 0;
            string input = match.Groups[0].Value;
            int position = 0, output = 0;
            bool negative = false;

            if (input[0] == '+')
            {
                if (input.Length >= 2 && (input[1] < '0' || input[1] > '9'))
                    return 0;
            }
            else if (input[0] == '-')
            {
                if (input.Length >= 2 && (input[1] < '0' || input[1] > '9'))
                    return 0;
                negative = true;
            }
            else if (!(input[0] >= '0' && input[0] <= '9'))
            {
                return 0;
            }

            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] >= '0' && input[i] <= '9')
                {
                    try
                    {
                        checked
                        {
                            if (!negative)
                                output += (int)Math.Pow(10, position++) * (input[i] - '0');
                            else
                                output -= (int)Math.Pow(10, position++) * (input[i] - '0');
                        }
                    }
                    catch (OverflowException)
                    {
                        output = (negative ? int.MinValue : int.MaxValue);
                        break;
                    }
                }
                else
                {
                    if ((output > 0 || output < 0) && input[i] != '-' && input[i] != '+')
                    {
                        position = 0;
                        output = 0; //reset output??
                    }
                }
            }

            return output;
        }
    }
}
