using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P001_Two_Sum
{
    public class Solution
    {
        /*
         * 19 / 19 test cases passed.
         * Status: Accepted.
         * Runtime: 715 ms
         */
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
                for (int j = 0; j < nums.Length; j++)
                    if (j != i && nums[i] + nums[j] == target)
                        return new int[] { i, j };
            return null;
        }
    }
}
