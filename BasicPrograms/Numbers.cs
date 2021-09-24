using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class Numbers
    {
        public void Swap()
        {
            // get numbers from user
            Console.WriteLine("Enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Before swapping, first number is {a} and second number is {b}.");
            a = a*b;
            b = a/b;
            a = a/b;
            Console.WriteLine($"After swapping, first number is {a} and second number is {b}.");
        }
    }
}
