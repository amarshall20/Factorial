using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a number.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(RecursiveFactorial(n));
            Console.ReadLine();
        }
        static int LoopingFactorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        static int RecursiveFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * RecursiveFactorial(n - 1);
        }
    }
}
