using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class VowelOrConsonant
    {
        // define constant string
        string VOWEL_STRING = "aeiouAEIOU";
        public void Check()
        {
            // get character from user
            Console.WriteLine("Enter a character to check");
            string testCharacter = Console.ReadLine();
            if (VOWEL_STRING.Contains(testCharacter))
            {
                Console.WriteLine($"{testCharacter} is a Vowel");
            }
            else
            {
                Console.WriteLine($"{testCharacter} is not a Vowel");
            }
        }
    }
}
