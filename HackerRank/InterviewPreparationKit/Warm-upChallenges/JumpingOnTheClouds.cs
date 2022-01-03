using System;
using System.Collections.Generic;

namespace HackerRank.InterviewPreparationKit.Warm_upChallenges
{
    public class JumpingOnTheClouds
    {
        /*
         * Complete the 'jumpingOnClouds' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY c as parameter.
         */

        public static int JumpingOnClouds_v1(List<int> c)
        {
            int numberOfJumpsRequired = 0;
            int i = 0;
            
            while (i < c.Count)
            {
                if (i + 2 < c.Count && c[i + 2] == 0)
                {
                    numberOfJumpsRequired++;
                    i += 2;
                }
                else if (i + 1 < c.Count && c[i + 1] == 0)
                {
                    numberOfJumpsRequired++;
                    i++;
                }
                else
                {
                    i++;
                }
            }

            return numberOfJumpsRequired;
        }
        
        public static int JumpingOnClouds_v2(List<int> c)
        {
            int numberOfJumpsRequired = 0;
            
            for (int i = 0; i < c.Count -1;)
            {
                if (c.Count > i + 2 && c[i + 2] == 1) i++;
                else i += 2;
                numberOfJumpsRequired++;
            }

            return numberOfJumpsRequired;
        }
    }
}