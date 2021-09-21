using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class PowerOfTwo
    {
        // initialize constants
        int BASE = 2;
        public void PrintTable()
        {
            // Read Maximum power between 0 and 32 from commandline argument
            Console.WriteLine("Enter a number from 0 to 31: ");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i=0; i <= N; i++)
            {
                double powerValue = Math.Pow(BASE, i);
                Console.WriteLine($"2^{i} = {powerValue}");
            }
        }        
    }
}
