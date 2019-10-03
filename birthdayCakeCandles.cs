using System;
/*
 * You are in charge of the cake for your niece's birthday 
 * the cake will have one candle for each year of her total age. 
 * When she blows out the candles, 
 *      she’ll only be able to blow out the tallest ones. 
 * Find out how many candles she can successfully blow out.
    
    example if your niece is turning 4 years old, 
        and the cake will have 
            4 candles of 
            height 4, 4, 1, 3, 
            
    she will be able to blow out 2 candles successfully, 
    since the tallest candles are of height 4 and there are 2 such candles.
 */
namespace birthdayCakeCandlesApp
{
    class birthdayCakeCandles
    {

        // Complete the birthdayCakeCandles function below.
        static int birthdayCakeCandles(int[] ar)
        {
            // sort low to high
            Array.Sort(ar);

            // nbr of candles; person's age
            int n = (ar.Length - 1);

            int value = 0;
            int max = ar[n];
            int nbrCandlesToBlowOut = 0;

            for (int i = n; i >=0; i--)
            {
                value = ar[i];
                System.Console.Write("{0} ", value);

                if (value == max) {
                    nbrCandlesToBlowOut++;
                }
            }

            System.Console.Write("nbrCandlesToBlowOut {0} ", nbrCandlesToBlowOut);
            return nbrCandlesToBlowOut;
        }

        static void Main(string[] args)
        {
 
            int[] ar = new int[] { 4, 4, 1, 3 };
            int result = birthdayCakeCandles(ar);
            System.Console.WriteLine("result {0} ", result);

            int[] ar2 = new int[] { 3,2,1,3 };
            int result2 = birthdayCakeCandles(ar2);
            System.Console.WriteLine("result2 {0} ", result2);

        }
    }
}
