using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class HarmonicNumber
    {
        // initialize constants
        int N = 0;

        // initialize variables
        double nthHorminValue = 0; 
        public void PrintNumber()
        {
            // Check if number is greater than zero or not and calculate N'th Harmonic number
            if (N > 0)
            {
                for (double i = 1; i <= N; i++)
                {
                    nthHorminValue = nthHorminValue + (1 / i);
                }
                // print Harmonic number value
                Console.WriteLine($"Nth Hormonic value of {N} is {nthHorminValue}");
            }
            else
            {
                Console.WriteLine("N is 0.No Harmonic value for 0");
            }
        }
    }
}
