using System;
/*
Display output as below pattern
     * 
    *** 
   *****
  *******
 *********
  *******
   *****
    ***
     * 
 */
namespace PatternApp
{
 
    class DiamondPattern
    {
        static public string Writepattern(int nbrSpaces, int nbrAsterisks)
        {
            string s = "";
            for (int ns = 0; ns <= nbrSpaces; ns++)
                s += " ";

            for (int na = 1; na <= nbrAsterisks; na++)
                s += "*";

            return s;
        }

        static void Main(string[] args)
        {
            Int16[] spaces = {4, 3, 2, 1, 0, 1, 2, 3, 4};
            Int16[] astrsk = {1, 3, 5, 7, 9, 7, 5, 3, 1};

            int length = astrsk.Length - 1;

            for (int i = 0; i <= length; i++)
            {
                Console.WriteLine(Writepattern(spaces[i], astrsk[i]));
            }
        }
    }
}
