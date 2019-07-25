using System.Collections.Generic;
using System.Linq;

namespace Library
{
    /* 
    https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem
    Plan
    - set maxScore, minscore = first score
    - Loop throgh the scores except first score
        - If score > maxScore => maxCout + 1 from zero, update maxScore = score
        - If score < mixScore => minCount +1 from zero, update minScore = score
    */
    public static class BreakingRecords
    {
        public static int[] FindMaxMin(int[] scores) {
            var result = new int[]{ 0, 0};
            var minScore= scores[0]; 
            var maxScore = scores[0];

            for (int i = 1; i < scores.Length; i++)
            {
                if(scores[i] > maxScore){
                    maxScore = scores[i];
                    result[0] += 1;

                }else if(scores[i] < minScore){
                    minScore = scores[i];
                    result[1] += 1;
                }
            }
            return result;
        }
    }
}