using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class Numbers
    {
        public void Swap(int a, int b)
        {
            Console.WriteLine($"Before swapping, first number is {a} and second number is {b}.");
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"After swapping, first number is {a} and second number is {b}.");
        }
    }
}
