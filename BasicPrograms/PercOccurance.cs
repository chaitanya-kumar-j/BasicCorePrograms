using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class PercOccurance
    {
        // initialize constants
        const int NUMBER_OF_FLIPS = 50;

        // initialize variables
        int headCount, tailCount;
        double headPercentage, tailPercentage;

        // initialize random floatong number generator
        Random random = new Random();

        // method to calculate percentage of each side of coin
        public Tuple<double, double> PercentageOccurance()
        {
             for (int i =1; i<= NUMBER_OF_FLIPS; i++)
            {
                double flipCheck = random.NextDouble();
                // Console.WriteLine(i + "           " + flipCheck);
                if (flipCheck < 0.5)
                {
                    tailCount++;
                    // Console.WriteLine("tail");
                }
                if (flipCheck > 0.5)
                {
                    headCount++;
                    // Console.WriteLine("head");
                }
                if (flipCheck == 0.5)
                {
                    Console.WriteLine("tie");
                }
            }
            headPercentage = (headCount * 100) / NUMBER_OF_FLIPS;
            tailPercentage = (tailCount * 100) / NUMBER_OF_FLIPS;
            return new Tuple<double, double>(headPercentage, tailPercentage);
        }
    }
}
