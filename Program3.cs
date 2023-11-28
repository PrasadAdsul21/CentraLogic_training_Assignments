using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentraLogic_Training_Assignment_1
{
    internal class Program3
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter Number to perform arithmetic operation :");
            var num1 = Console.ReadLine();
            int n1 = int.Parse(num1);
            Console.Write("enter second number :");
            var num2 = Console.ReadLine();
            int n2 = int.Parse(num2);
            Console.Write("enter your choice for performing specific arithmetic operation accordingly :");
            var choice = Console.ReadLine();
            string check = choice.ToLower();

            switch (check)
            {
                case "addition":
                    Console.WriteLine("Addition of entered  numbers " + n1 + ", " + n2 + " is " + (n1 + n2));
                    break;

                case "subtraction":
                    Console.WriteLine("Subtraction of entered numbers " + n1 + ", " + n2 + " is " + (n1 - n2));
                    break;

                case "multiplication":
                    Console.WriteLine("multiplication of entered numbers " + n1 + ", " + n2 + " is " + (n1 * n2));
                    break;

                case "division":
                    Console.WriteLine("division of entered numbers " + n1 + ", " + n2 + " is " + (n1 / n2));
                    break;

                case "modulus":
                    Console.WriteLine("modulus of entered numbers " + n1 + ", " + n2 + " is " + (n1 % n2));
                    break;

                default:
                    Console.WriteLine("please check spelling of entered choice / Invalid Choice");
                    break;
            }
        }
    }
}
