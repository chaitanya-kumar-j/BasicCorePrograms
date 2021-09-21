using System;

namespace BasicPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            // Select the Program number
            // 1. FlipCoin, 2. CheckLeapYear, 3. PowerOf2Table, 4. HarmonicNumber, 5. PrimeFactorization
            // 6. QuotientAndRemainder
            Console.WriteLine("Select and enter the problem number between 1 to 10\n" +
                "(1. FlipCoin, 2. CheckLeapYear, 3. PowerOf2Table, 4. HarmonicNumber, \n 5. PrimeFactorization," +
                " 6. QuotientAndRemainder, 7. SwapNumbers,\n 8. EvenOrOdd, 9. VowelOrConsonant, 10. LargestNumber): ");
            int problemNumber = Convert.ToInt32(Console.ReadLine());
            switch (problemNumber)
            {
                case 1:
                    var tuple = new PercOccurance().PercentageOccurance();
                    Console.WriteLine($"Head occurance percentage is: {tuple.Item1}%");
                    Console.WriteLine($"Tail occurance percentage is: {tuple.Item2}%");
                    break;
                case 2:
                    new LeapYear().Check();
                    break;
            }
        }
    }
}
