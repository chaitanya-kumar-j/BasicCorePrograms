using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class PrimeFactors
    {
        public void Factorizaton()
        {
            // get number from user
            Console.WriteLine("Enter the number to which factors to be found");
            int number = Convert.ToInt32(Console.ReadLine());
            while (number % 2 == 0)
            {
                Console.Write(2 + " ");
                number /= 2;
            }

            // n must be odd at this point. So we can
            // skip one element (Note i = i +2)
            for (int i = 3; i*i <= number; i += 2)
            {
                // While i divides n, print i and divide n
                while (number % i == 0)
                {
                    Console.Write(i + " ");
                    number /= i;
                }
            }

            // This condition is to handle the case whien
            // n is a prime number greater than 2
            if (number > 2)
                Console.Write(number);
        }
    }
}
