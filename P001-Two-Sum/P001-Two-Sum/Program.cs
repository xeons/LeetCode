using System;

namespace P001_Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] result = solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            Console.WriteLine("Result: [{0}], Expected: [{1}]", string.Join(", ", result), "0, 1");
            Console.ReadLine();
        }
    }
}
