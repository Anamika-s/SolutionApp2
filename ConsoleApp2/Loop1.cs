using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Loop1
    {
        static void Main()
        {
            // print from 1 to 10
            // while loop

            Console.WriteLine("Using while loop");
            int n = 1; // initialze
            while(n<=10) // condition
            {
                Console.WriteLine(n);
                n++;   // increment 
            }

            Console.WriteLine("Using do while loop");
            n = 1;
            do
            {
                Console.WriteLine(n);
                n++;
            } while(n<=10);

            Console.WriteLine("Using for loop");
            for(int i=1;i<=10;i++)
                Console.WriteLine(i);



        }
    }
}
