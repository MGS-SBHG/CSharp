using System;

// Display patterns 

namespace PatternApp
{
 
    class PatternDisplay
    {
        static public string WriteAsterisks(int nbrAsterisks)
        {
            string s = "";

            for (int na = 0; na <= nbrAsterisks; na++)
                if (na == 0)
                    s += "";
                else
                    s += "*";
            
            return s;
        }

        static public string WriteSpaces(int nbrSpaces)
        {
            string s = "";
            for (int ns = 0; ns <= nbrSpaces; ns++)
                s += " ";

            return s;
        }
        static public string Writepattern(int nbrSpaces, int nbrAsterisks)
        {
            string s = "";
            for (int ns = 0; ns <= nbrSpaces; ns++)
                s += " ";

            for (int na = 1; na <= nbrAsterisks; na++)
                s += "*";

            return s;
        }

        static public string Writepattern2(int nbrAsterisks, int nbrSpaces, int nbrAsterisks2)
        {
            string s = "";

            for (int na = 1; na <= nbrAsterisks; na++)
                s += "*";

            for (int ns = 1; ns <= nbrSpaces; ns++)
                s += " ";

            for (int na2 = 1; na2 <= nbrAsterisks2; na2++)
                s += "*";

            return s;
        }

        static public string Writepattern3(int nbrAsterisks, int nbrSpaces, int nbrAsterisks2, int nbrSpaces2, int nbrAsterisks3)
        {
            string s = "";

            for (int na = 1; na <= nbrAsterisks; na++)
                s += "*";

            for (int ns = 1; ns <= nbrSpaces; ns++)
                s += " ";

            for (int na2 = 1; na2 <= nbrAsterisks2; na2++)
                s += "*";

            for (int ns = 1; ns <= nbrSpaces2; ns++)
                s += " ";

            for (int na2 = 1; na2 <= nbrAsterisks3; na2++)
                s += "*";

            return s;
        }

        static public string Writepattern4(int nbrAsterisks, int nbrSpaces, int nbrAsterisks2, int nbrSpaces2, int nbrAsterisks3, int nbrSpaces3, int nbrAsterisks4)
        {
            string s = "";

            for (int na = 1; na <= nbrAsterisks; na++)
                s += "*";

            for (int ns = 1; ns <= nbrSpaces; ns++)
                s += " ";

            for (int na2 = 1; na2 <= nbrAsterisks2; na2++)
                s += "*";

            for (int ns = 1; ns <= nbrSpaces2; ns++)
                s += " ";

            for (int na2 = 1; na2 <= nbrAsterisks3; na2++)
                s += "*";

            //int nbrSpaces3, 
                
            //int nbrAsterisks4

            return s;
        }

        static void Main(string[] args)
        {
            // Pattern 1 Diamond
            Int16[] spaces = {4, 3, 2, 1, 0, 1, 2, 3, 4};
            Int16[] astrsk = {1, 3, 5, 7, 9, 7, 5, 3, 1};

            int length = astrsk.Length - 1;

            for (int i = 0; i <= length; i++)
            {
                Console.WriteLine(Writepattern(spaces[i], astrsk[i]));
            }
            Console.WriteLine();


            // Pattern 2 Upside-Down Right-Angle Triangle
            Int16[] astrsk2 = { 8, 7, 6, 5, 4, 3, 2, 1 };

            int length2 = astrsk2.Length - 1;

            for (int i = 0; i <= length2; i++)
            {
                Console.WriteLine(Writepattern(0, astrsk2[i]));
            }
            Console.WriteLine();


            // Pattern 3 Right-Angle Triangle
            Int16[] astrsk3 = { 1,2,3,4,5,6,7,8 };

            int length3 = astrsk3.Length - 1;

            for (int i = 0; i <= length3; i++)
            {
                Console.WriteLine(Writepattern(0, astrsk3[i]));
            }
            Console.WriteLine();


            // Pattern 4 Two-Triangles
            Int16[] astrsk4 = { 1, 2, 3, 4, 5, 6, 7, 8};

            int length4 = astrsk4.Length - 1;

            for (int i = 0; i <= length4; i++)
            {
                Console.WriteLine(Writepattern2(astrsk4[i], 1, astrsk4[i]));
            }
            Console.WriteLine();


            // Pattern 5 Non-filled Rectangle
            Int16[] astrsk5 = {7, 1, 1, 1, 1, 1, 1, 7};
            Int16[] spaces5 = {0, 5, 5, 5, 5, 5, 5, 0};
            Int16[] astrsk6 = {0, 1, 1, 1, 1, 1, 1, 0};

            int length5 = astrsk5.Length - 1;

            for (int i = 0; i <= length5; i++)
            {
                Console.WriteLine(Writepattern2(astrsk5[i], spaces5[i], astrsk6[i]));
            }
            Console.WriteLine();


            // Pattern 6 Zig-Zag Pattern
            // line 1
            Int16[] astrsk7 = {1, 17, 1};      
            Int16[] spaces7 = {7, 8, 0}; 

            int length7 = astrsk7.Length - 1;

            for (int i = 0; i <= length7; i++)
            {
                Console.Write(WriteAsterisks(astrsk7[i]));
                Console.Write(WriteSpaces(spaces7[i]));
            }
            Console.WriteLine();
      
            // line 2
            Int16[] astrsk8 = {2, 8, 7, 2}; 
            Int16[] spaces8 = {6, 2, 6, 0};

            int length8 = astrsk8.Length - 1;

            for (int i = 0; i <= length8; i++)
            {
                Console.Write(WriteAsterisks(astrsk8[i]));
                Console.Write(WriteSpaces(spaces8[i]));
            }
            Console.WriteLine();

            //Line 3
            Int16[] astrsk9 = {3, 7, 6, 3}; 
            Int16[] spaces9 = {5, 4, 5, 0}; 

            int length9 = astrsk9.Length - 1;

            for (int i = 0; i <= length9; i++)
            {
                Console.Write(WriteAsterisks(astrsk9[i]));
                Console.Write(WriteSpaces(spaces9[i]));
            }
            Console.WriteLine();
            
            //Line 4
            Int16[] astrsk10 = {4, 6, 5, 4};
            Int16[] spaces10 = {4, 6, 4, 0};

            int length10 = astrsk10.Length - 1;

            for (int i = 0; i <= length10; i++)
            {
                Console.Write(WriteAsterisks(astrsk10[i]));
                Console.Write(WriteSpaces(spaces10[i]));
            }
            Console.WriteLine();

            // Line 5
            Int16[] astrsk11 = {5, 5, 4, 5};
            Int16[] spaces11 = {3, 8, 3, 0};

            int length11 = astrsk11.Length - 1;

            for (int i = 0; i <= length11; i++)
            {
                Console.Write(WriteAsterisks(astrsk11[i]));
                Console.Write(WriteSpaces(spaces11[i]));
            }
            Console.WriteLine();

            // Line 6
            Int16[] astrsk12 = {6, 4, 3, 6};
            Int16[] spaces12 = {2, 10, 2, 0};

            int length12 = astrsk12.Length - 1;

            for (int i = 0; i <= length12; i++)
            {
                Console.Write(WriteAsterisks(astrsk12[i]));
                Console.Write(WriteSpaces(spaces12[i]));
            }
            Console.WriteLine();

            // Line 7
            Int16[] astrsk13 = {7, 3, 2, 7};
            Int16[] spaces13 = {1, 12, 1, 0};

            int length13 = astrsk13.Length - 1;

            for (int i = 0; i <= length13; i++)
            {
                Console.Write(WriteAsterisks(astrsk13[i]));
                Console.Write(WriteSpaces(spaces13[i]));
            }
            Console.WriteLine();

            //Line 8
            Int16[] astrsk14 = {11, 10}; 
            Int16[] spaces14 = {14, 14};

            int length14 = astrsk14.Length - 1;

            for (int i = 0; i <= length14; i++)
            {
                Console.Write(WriteAsterisks(astrsk14[i]));
                Console.Write(WriteSpaces(spaces14[i]));
            }
            Console.WriteLine();
    
        }
    }
}
