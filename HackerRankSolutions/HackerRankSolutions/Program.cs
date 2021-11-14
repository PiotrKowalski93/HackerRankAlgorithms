using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRankSolutions
{
    class Program
    {
        class Result
        {

            /*
             * Complete the 'aVeryBigSum' function below.
             *
             * The function is expected to return a LONG_INTEGER.
             * The function accepts LONG_INTEGER_ARRAY ar as parameter.
             */

            public static int diagonalDifference(List<List<int>> arr)
            {
                int primarySum = 0;
                int secondarySum = 0;

                for (int i = 0, j = arr.Count - 1; i < arr.Count; i++, j -= i)
                {
                    primarySum += arr[i][i];

                    secondarySum += arr[j][i];
                }

                return Math.Abs(primarySum - secondarySum);
            }

        }

        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.diagonalDifference(arr);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
