// find first repeated character in string using hash table. 

using System;
using System.Collections;

namespace FirstRepeatedCharacterApp
{
    class FirstRepeatedCharacter
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add(1, "DAAEEFF");
            ht.Add(2, "TUVWWXXXYZ");

            string str1 = (string)ht[1];
            string str2 = (string)ht[2];

            char repChar = FindFirstDupeChar(str1);
            char repChar2 = FindFirstDupeChar(str2);

            Console.WriteLine("Repeating char of {0} is {1}", str1, repChar);
            Console.WriteLine("Repeating char is {0} is {1}", str2, repChar2);

        }

        static public char FindFirstDupeChar(string s)
        {
            bool foundDupe = false;
            char dupeChar = ' ';
            for (int i = 1; i < s.Length && !foundDupe; ++i)
            {
                if (foundDupe = s[i] == s[i - 1])
                    dupeChar = s[i];
            }
            return dupeChar;
        }

    }
}
