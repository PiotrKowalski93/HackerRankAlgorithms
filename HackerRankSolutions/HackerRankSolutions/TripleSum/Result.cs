using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.TripleSum
{
    public class Result
    {
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int aPoints = 0;
            int bPoints = 0;

            for (int i = 0; i < 3; i++)
            {
                if (a[i] > b[i]) aPoints += 1;
                if (a[i] < b[i]) bPoints += 1;
            }

            return new List<int>() { aPoints, bPoints };
        }
    }
}
