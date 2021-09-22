using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class EvenOrOdd
    {
        public void Check(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine($"Given number{a} is Even number");
            }
            else
            {
                Console.WriteLine($"Given number{a} is not an Even number");
            }
        }
    }
}
