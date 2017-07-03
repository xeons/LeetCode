using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P008_String_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.MyAtoi("1024"));
            Console.WriteLine(solution.MyAtoi("-1024"));
            Console.WriteLine(solution.MyAtoi(uint.MaxValue.ToString()));
            Console.WriteLine(solution.MyAtoi("-" + uint.MaxValue.ToString()));
            Console.ReadLine();
        }
    }
}
