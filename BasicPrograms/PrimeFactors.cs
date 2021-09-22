using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class PrimeFactors
    {
        // initialize constants
        int N = 100;
        public void Factorizaton()
        {
            int n = N, j = 0;
            while (j < n)
            {
                int i = j;
                if (i == 0 || i == 1)
                {
                    i++;
                    break;
                }
                if (i > 1 & n % i != 0)
                {
                    while (i < n)
                    {
                        if (i > 1 & n % i != 0)
                        {
                            
                        }
                    }
                }                
            }            
        }
    }
}
