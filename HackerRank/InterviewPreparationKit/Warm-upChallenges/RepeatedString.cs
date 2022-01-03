using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.InterviewPreparationKit.Warm_upChallenges
{
    public class RepeatedString
    {
        /*
         * Complete the 'rotLeft' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
         *  2. INTEGER d
         */
        public static long RepeatedString_v1(string s, long n)
        {
            char currentLetter = 'a';
            long completeStringsCount = n / s.Length;
            long lettersCountInLastSting = s.ToCharArray().Take((int) (n % s.Length)).Count(x => currentLetter == x);
            long lettersCountInSingleString = s.ToCharArray().Count(x => currentLetter == x);
            long lettersCountInFullString = lettersCountInSingleString * completeStringsCount + lettersCountInLastSting;

            return lettersCountInFullString;
        }
    }
}