using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public static class GradingStudent
    {
        public static List<int> RoundGrade(List<int> grades) 
        {
            var result = new List<int>();

            foreach (var grade in grades)
            {
                if(grade <= 37 || grade % 5 == 0){
                    result.Add(grade);
                }else
                {
                    var multiNumber = FindMultiNumber(grade);
                    
                    if(multiNumber - grade < 3){
                        result.Add(multiNumber);
                    }else{
                        result.Add(grade);
                    }
                }
            }

            return result;
        }

        public static int FindMultiNumber(int number)
        {
            var result = number;

            while (result % 5 != 0 )
            {
                result++;
            }

            return result;
        }
    }
}