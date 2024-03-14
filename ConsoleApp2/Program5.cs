using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program5
    {
         static void Main()
        {
            int num1, num2;
            string ch;  //+ 1
            Console.WriteLine("Enter Num1 ");
            num1 = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter Num2 ");
            num2 = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter choice");
            ch =  Console.ReadLine();
            if (ch == "1" || ch=="+")
                Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
            else if (ch == "2" || ch=="-")
                Console.WriteLine($"Differece of {num1} and {num2} is {num1 - num2}");
            else if (ch == "3" || ch=="*")
                Console.WriteLine($"Product of {num1} and {num2} is {num1 * num2}");
            else if (ch == "4" || ch=="/")
                Console.WriteLine($"Quotient of {num1} and {num2} is {num1 / num2}");
            else if (ch == "5" || ch=="%")
                Console.WriteLine($"Remainder of {num1} and {num2} is {num1 % num2}");
            else
                Console.WriteLine("Invalid choice");
        }
    }
}
