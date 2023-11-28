using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentraLogic_Training_Assignment_1
{
    internal class Program2
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Dear user enter a number to perform square of addition operation");
            var num1 = Console.ReadLine();
            int n1 = int.Parse(num1);
            Console.WriteLine("Dear user enter another number to perform same operation");
            var num2 = Console.ReadLine();
            int n2 = int.Parse(num2);
            int sqNumSum = n1 * n1 + n2 * n2 + 2 * n1 * n2;
            Console.WriteLine("Formula : (A+B)2 = A*A + B*B + 2*A*B");
            Console.WriteLine("Square of sum of numbers" + n1 + " and " + n2 + " is " + sqNumSum);
        }
    }
}
