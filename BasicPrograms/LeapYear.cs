using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class LeapYear
    {
        // initialize constants
        int NUMBER_OF_DIGITS = 4;

        // Randome year generator
        Random random = new Random();

        // Check leap year or not
        public void Check()
        {
            // random year creation
            int testYear = random.Next(1000,10000);

            // check whether the test year has 4 digits and is leap year or not
            if (((testYear >= Math.Pow(10, NUMBER_OF_DIGITS-1)) && (testYear < Math.Pow(10,NUMBER_OF_DIGITS))))
            {
                if (testYear % 4 == 0) 
                {
                    if (testYear % 100 == 0)
                    {
                        if (testYear % 400 == 0)
                        {
                            Console.WriteLine($"{testYear} is a leap year.");
                        }
                        else
                        {
                            Console.WriteLine($"{testYear} is not a leap year.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{testYear} is a leap year.");
                    }
                }
                else
                {
                    Console.WriteLine($"{testYear} is not a leap year.");
                }
            }
            else
            {
                Console.WriteLine($"{testYear} is not a {NUMBER_OF_DIGITS} digit year.");
            }
        }
    }
}
