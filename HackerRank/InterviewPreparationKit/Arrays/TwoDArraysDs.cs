using System;
using System.Collections.Generic;

namespace HackerRank.InterviewPreparationKit.Arrays
{
    public class TwoDArraysDs {
        
        /*
         * Complete the 'hourglassSum' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */
        
        public static int hourglassSum_v1(List<List<int>> arr)
        {
            int? maxSum = null;
            // "List<(int, int)>" don't supported on HackerRank
            List<Tuple<int, int>> hourglassPointers = new List<Tuple<int, int>>
            {
                // "New ()" don't supported on HackerRank
                new Tuple<int, int> (0, 0),
                new Tuple<int, int> (0, 1),
                new Tuple<int, int> (0, 2),
                new Tuple<int, int> (1, 1),
                new Tuple<int, int> (2, 0),
                new Tuple<int, int> (2, 1),
                new Tuple<int, int> (2, 2)
            };

            for (int i = 0; i < arr.Count - 2; i++)
            {
                List<int> internalArray = arr[i];

                for (int j = 0; j < internalArray.Count - 2; j++)
                {
                    int sum = 0;
                    
                    foreach (var pointer in hourglassPointers)
                    {
                        sum += arr[i + pointer.Item1][j + pointer.Item2];
                    }

                    if (maxSum == null || sum > maxSum)
                    {
                        maxSum = sum;
                    }
                }
            }

            return maxSum ?? 0;
        }
    }
}