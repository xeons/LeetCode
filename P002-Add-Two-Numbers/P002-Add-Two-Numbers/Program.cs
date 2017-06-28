using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P002_Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            // Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
            // Output: 7-> 0-> 8

            var input1 = new ListNode(2);
            input1.next = new ListNode(4);
            input1.next.next = new ListNode(3);

            var input2 = new ListNode(5);
            input2.next = new ListNode(6);
            input2.next.next = new ListNode(4);

            var answer = solution.AddTwoNumbersV1(input1, input2);
            for (ListNode x1 = answer; x1 != null; x1 = x1?.next)
                Console.Write(x1.val + " ");
            Console.Write("\n");

            answer = solution.AddTwoNumbersV2(input1, input2);
            for (ListNode x1 = answer; x1 != null; x1 = x1?.next)
                Console.Write(x1.val + " ");
            Console.Write("\n");

            Console.ReadLine();
        }
    }
}
