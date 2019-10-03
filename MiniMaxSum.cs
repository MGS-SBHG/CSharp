using System;

/*
Given five positive integers, 
find the minimum and maximum values 
calculated by summing exactly four of the five integers. 
Then print the respective minimum and maximum values 
as a single line of two space-separated long integers.
*/
namespace MiniMaxSumApp
{
    class Program
    {

        // Complete the miniMaxSum function below.
        static void miniMaxSum(int[] arr)
        {

            Array.Sort(arr);

            int length = arr.Length;
            ulong min = 0;
            ulong max = 0;

            for (int i = 0; i <= length - 2; i++)
            {
                min += (ulong)arr[i];
            }

            for (int i = 1; i <= length - 1; i++)
            {
                max += (ulong)arr[i];
            }

            System.Console.WriteLine("{0} {1}", min, max);

        }

        static void Main(string[] args)
        {
            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            // minimum sum s/b
            // 1+3+5+7=16

            // maximum sum s/b
            // 3+5+7+9=24 	
            int[] arr = new int[] { 1, 3, 5, 7, 9 };


            // 7 69 2 221 8974
            // min = 2 + 7 + 69 + 221
            // max = 7 + 69 + 221 + 8974
            int[] arr2 = new int[] { 7, 69, 2, 221, 8974};

            // min max
            // 16 24
            miniMaxSum(arr);

            // min  max
            // 299  9271
            miniMaxSum(arr2);

        }
    }
}
