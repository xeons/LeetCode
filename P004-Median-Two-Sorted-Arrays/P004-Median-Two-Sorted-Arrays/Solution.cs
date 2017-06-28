using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P004_Median_Two_Sorted_Arrays
{
    class Solution
    {
        /**
         * 2080 / 2080 test cases passed.
	     * Status: Accepted
	     * Runtime: 239 ms
         */
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] combined = nums1.Concat(nums2).OrderBy(i => i).ToArray();
            return combined.Length % 2 == 0 ? (double)(combined[(combined.Length / 2) - 1] + combined[(combined.Length / 2)]) / 2 : combined[(int)combined.Length / 2];
        }
    }
}
