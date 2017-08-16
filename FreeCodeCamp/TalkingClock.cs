using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeCodeCamp
{
    class TalkingClock
    {
        public static void InputTime(string strHoursMin)
        {
            string[] arrHoursMin = new string[2];
            char[] splitchar = { ':' };
            arrHoursMin = strHoursMin.Split(splitchar);
            int intHour = Convert.ToInt16(arrHoursMin[0]);
            int intMin = Convert.ToInt16(arrHoursMin[1]);
            string strAMPM = GetAMPM(intHour);
            string strHour = GetHour(intHour);
            string strMin = GetMin(intMin);

            Console.WriteLine("{0} {1} {2}", strHour, strMin, strAMPM);
        }

        public static string GetAMPM(int intHour)
        {
            if (intHour < 12)
            {
                return "AM";
            }
            else
            {
                return "PM";
            }
        }

        public static string GetHour(int intHour)
        {
            string OutHour = string.Empty;

            string[] HoursList = new string[12];
            HoursList[0] = "12";
            HoursList[1] = "1";
            HoursList[2] = "2";
            HoursList[3] = "3";
            HoursList[4] = "4";
            HoursList[5] = "5";
            HoursList[6] = "6";
            HoursList[7] = "7";
            HoursList[8] = "8";
            HoursList[9] = "9";
            HoursList[10] = "10";
            HoursList[11] = "11";

            OutHour = HoursList[intHour % 12];

            return OutHour;
        }

        public static string GetMin(int intMin)
        {
            string OutMin = string.Empty;
            string[] MinsList = new string[10];
            MinsList[0] = "";
            MinsList[1] = "1";
            MinsList[2] = "2";
            MinsList[3] = "3";
            MinsList[4] = "4";
            MinsList[5] = "5";
            MinsList[6] = "6";
            MinsList[7] = "7";
            MinsList[8] = "8";
            MinsList[9] = "9";

            if (intMin < 10)
            {
                if (intMin == 0)
                    OutMin = "";
                else
                    OutMin = "Oh" + MinsList[intMin];
            }
            else if (intMin < 20)
            {
                string[] Teens = new string[10];
                Teens[0] = "10";
                Teens[1] = "11";
                Teens[2] = "12";
                Teens[3] = "13";
                Teens[4] = "14";
                Teens[5] = "15";
                Teens[6] = "16";
                Teens[7] = "17";
                Teens[8] = "18";
                Teens[9] = "19";

                OutMin = Teens[intMin % 10];
            }
            else
            {
                string[] Tens = new string[6];
                Tens[0] = "";
                Tens[1] = "";
                Tens[2] = "Twenty";
                Tens[3] = "Thirty";
                Tens[4] = "Forty";
                Tens[5] = "Fifty";

                double Min1 = (intMin / 10);
                string Min2 = (Convert.ToInt32(Math.Floor(Min1)).ToString());
                string Min3 = MinsList[intMin % 10];
            }

            return OutMin;
        }
    }
}
