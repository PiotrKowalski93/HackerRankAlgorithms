using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.DiagonalDifference
{
    class Result
    {
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
}
