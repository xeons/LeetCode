﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P002_Add_Two_Numbers
{
    class Solution
    {
        /**
         * 1562 / 1562 test cases passed.
         * Status: Accepted
         * Runtime: 166 ms
         */
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            StringBuilder result = new StringBuilder();

            int carryOver = 0;
            for (ListNode x1 = l1, x2 = l2; x1 != null || x2 != null; x1 = x1?.next, x2 = x2?.next)
            {
                int finalVal = (x1 != null ? x1.val : 0) + (x2 != null ? x2.val : 0) + carryOver;
                carryOver = Math.Abs(finalVal / 10);
                result.Append((finalVal % 10).ToString());
            }

            if (carryOver == 1)
                result.Append("1");

            string resultString = result.ToString();

            ListNode head = new ListNode(int.Parse(resultString[0].ToString()));
            ListNode pointer = head;
            for (int i = 1; i < resultString.Length; i++)
            {
                pointer.next = new ListNode(int.Parse(resultString[i].ToString()));
                pointer = pointer.next;
            }

            return head;
        }
    }
}
