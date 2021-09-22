using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class GreatestNumber
    {
        public void Check()
        {
            // get three numbers from user
            Console.WriteLine("Enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber>secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine($"{firstNumber} is greaterthan {secondNumber} and {thirdNumber}");
            }
            if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                Console.WriteLine($"{secondNumber} is greaterthan {firstNumber} and {thirdNumber}");
            }
            if (thirdNumber > firstNumber && thirdNumber > secondNumber)
            {
                Console.WriteLine($"{thirdNumber} is greaterthan {firstNumber} and {secondNumber}");
            }
        }
    }
}
