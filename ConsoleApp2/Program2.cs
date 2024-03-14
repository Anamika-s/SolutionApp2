using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    // Debugging > Want to see program flow
    // We have to add breakpoint at statement frm where we want to see program flow
    // We have run program in debug mode using F10, F11 Keys


    internal class Program2
    {
        static void Main()
        {
            int num1, num2;
            Console.WriteLine("Enter Num1");
            num1 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Num2");
            num2 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
            Console.WriteLine($"Difference of {num1} and {num2} is {num1 - num2}");
            Console.WriteLine($"Product of {num1} and {num2} is {num1 * num2}");
            Console.WriteLine($"Quotient of {num1} and {num2} is {num1 / num2}");
            Console.WriteLine($"Remainder of {num1} and {num2} is {num1 % num2}");



        }
    }
}
