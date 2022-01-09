using System.Collections.Generic;
using System.Linq;

namespace HackerRank.InterviewPreparationKit.Arrays
{
    public class LeftRotation
    {
        /*
         * Complete the 'rotLeft' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
         *  2. INTEGER d
         */

        public static List<int> rotLeft_v1(List<int> a, int d)
        {
            int[] leftRotatedArray = new int[a.Count];
            int indexRotated = d % a.Count;
            
            for (int i = 0; i < a.Count; i++)
            {
                int newIndex;
                
                if (indexRotated > i)
                {
                    newIndex = a.Count - indexRotated + i;
                }
                else
                {
                    newIndex = i - indexRotated;
                }
                
                leftRotatedArray[newIndex] = a[i];
            }

            return leftRotatedArray.ToList();
        }
    }
}