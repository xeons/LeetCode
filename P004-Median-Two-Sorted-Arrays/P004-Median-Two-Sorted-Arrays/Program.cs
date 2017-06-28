using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P004_Median_Two_Sorted_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Console.WriteLine(solution.FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2 })); // 2.0
            Console.WriteLine(solution.FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 3, 4 })); // 2.5
            Console.WriteLine(solution.FindMedianSortedArrays(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 })); // 3.5
            Console.WriteLine(solution.FindMedianSortedArrays(new int[] { 1 }, new int[] { 2 })); // 1.5
            Console.WriteLine(solution.FindMedianSortedArrays(new int[] { }, new int[] { 1 })); // 1
            Console.WriteLine(solution.FindMedianSortedArrays(new int[] { 1, 1 }, new int[] { 1, 2 })); // 1

            Console.ReadLine();
        }
    }
}
