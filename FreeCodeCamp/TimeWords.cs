using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeCodeCamp
{
    class TimeWords
    {
        public string strHours;
        public string strMinutes;
        public string strAMPM;

        public TimeWords (string strHours, string strMinutes, string strAMPM)
        {
            this.strHours = strHours;
            this.strMinutes = strMinutes;
            this.strAMPM = strAMPM;
        }
    }
}
