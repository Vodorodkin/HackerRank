namespace HackerRank.InterviewPreparationKit.Warm_upChallenges
{
    public class CountingValleys
    {
        /*
         * Complete the 'countingValleys' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER steps
         *  2. STRING path
         */

        public static int CountingValleys_v1(int steps, string path)
        {
            int valleysCount = 0;
            int currentLevel = 0; //start at sea level

            foreach (char currentStep in path)
            {
                if (currentStep == 'U')
                {
                    currentLevel++;
                }
                else
                {
                    currentLevel--;
                }

                if (currentLevel == 0)
                {

                    if (currentStep == 'U')
                    {
                        valleysCount++;
                    }
                }
            }

            return valleysCount;
        }
    }
}