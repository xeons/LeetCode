using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P007_Reverse_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Console.WriteLine(solution.Reverse(-123));              // -321
            Console.WriteLine(solution.Reverse(-456));              // -654
            Console.WriteLine(solution.Reverse(123456));            // 654321
            Console.WriteLine(solution.Reverse(-2147483648));       // 0

            Console.ReadLine();
        }
    }
}
