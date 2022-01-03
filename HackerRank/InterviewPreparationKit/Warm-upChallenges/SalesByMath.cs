using System.Collections.Generic;
using System.Linq;

namespace HackerRank.InterviewPreparationKit.Warm_upChallenges
{
    class SalesByMath
    {
        /*
         * Complete the 'sockMerchant' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. INTEGER_ARRAY ar
         */

        public static int SockMerchant_v1(int n, List<int> ar)
        {
            int pairsCount = 0;
            List<int> tempList = new List<int>();

            foreach (var item in ar)
            {
                if (tempList.Contains(item))
                {
                    pairsCount++;
                    tempList.Remove(item);
                }
                else
                {
                    tempList.Add(item);
                }
            }

            return pairsCount;
        }

        public static int SockMerchant_v2(int n, List<int> ar)

        {
            int pairsCount = 0;
            List<int> distinctList = ar.Distinct().ToList();

            foreach (var item in distinctList)
            {
                pairsCount += ar.Count(x => x == item) / 2;
            }

            return pairsCount;
        }
    }
}
