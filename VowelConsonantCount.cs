// Count a total number of vowel or consonant in a string.

using System;
namespace VowelConsonent
{
    class VowelConsonantCount
    {
        public int VowelCount(string phrase)
        {
            int vowel_total = 0;
            string temp_phrase = phrase.ToLower();
            for (int i = 0; i < temp_phrase.Length; i++)
            {
                if (temp_phrase.Contains("a") || temp_phrase.Contains("e") || temp_phrase.Contains("i") || temp_phrase.Contains("o") || temp_phrase.Contains("u"))
                {
                    vowel_total++;
                }
            }
            return vowel_total;
        }

        public int ConsonantCount(string phrase)
        {
            int consonant_total = 0;
            string temp_phrase = phrase.ToLower();
            for (int i = 0; i < temp_phrase.Length; i++)
            {
                if (!temp_phrase.Contains("a")) && (!temp_phrase.Contains("e")) && (!temp_phrase.Contains("i")) && (!temp_phrase.Contains("o")) && (!temp_phrase.Contains("u"))
                {
                    consonant_total++;
                }
            }
            return consonant_total;
        }
        static void Main(string[] args)
        {
            string sample = "SummitWorks";
            Console.WriteLine("Number of vowels {0}", VowelCount(sample));
            Console.WriteLine("Number of  consonents {0}", ConsonantCount(sample));
        }
    }
}