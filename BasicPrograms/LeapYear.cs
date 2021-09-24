using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class LeapYear
    {
        // initialize constants
        int NUMBER_OF_DIGITS = 4;

        // Check leap year or not
        public void Check()
        {
            // random year creation by user
            Console.WriteLine($"Enter a {NUMBER_OF_DIGITS} digit year");
            int testYear = Convert.ToInt32(Console.ReadLine());

            // check whether the test year has 4 digits and is leap year or not
            if (((testYear >= Math.Pow(10, NUMBER_OF_DIGITS-1)) && (testYear < Math.Pow(10,NUMBER_OF_DIGITS))))
            {
                if (testYear % 4 == 0 && testYear % 100 == 0 || testYear % 400 == 0)
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
                Console.WriteLine($"{testYear} is not a {NUMBER_OF_DIGITS} digit year.");
            }
        }
    }
}
