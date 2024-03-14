using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program6
    {
        static void Main()
        {
            int num1, num2;
            string ch;
            Console.WriteLine("Enter Num1 ");
            num1 = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter Num2 ");
            num2 = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter choice");
            ch = Console.ReadLine();
            switch (ch)
            {
                case "1":
                case "+":
                    Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
                    break;
                case "2":
                case "-":
                    Console.WriteLine($"Differece of {num1} and {num2} is {num1 - num2}");
                    break;
                case "3":
                case "*":
                    Console.WriteLine($"Product of {num1} and {num2} is {num1 * num2}");
                    break;
                case "4":
                case "/":
                    Console.WriteLine($"Quotient of {num1} and {num2} is {num1 / num2}");
                    break;
                case "5":
                case "%":
                    Console.WriteLine($"Remainder of {num1} and {num2} is {num1 % num2}");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
