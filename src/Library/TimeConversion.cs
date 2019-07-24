using System.Linq;

namespace Library
{
    public static class TimeConversion
    {
        public static string Converse(string time) 
        {
            var timeArr = time.Split(':');
            var status = timeArr[timeArr.Length -1].Substring(2, 2);
            timeArr[timeArr.Length -1] = timeArr[timeArr.Length -1].Substring(0, 2);
            int hour = int.Parse(timeArr[0]);

            var startNumber = status == "AM" ? 0 : 12;

            if(hour >= 12){
                hour = 0;
            }

            timeArr[0] = (startNumber + hour).ToString("00");
            
            return string.Join(":", timeArr);
        }
    }
}