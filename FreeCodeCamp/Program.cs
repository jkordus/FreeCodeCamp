using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeCodeCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            TalkingClock.InputTime("22:03");
            TalkingClock.InputTime("02:18");
            TalkingClock.InputTime("00:00");
            TalkingClock.InputTime("12:09");

            Console.ReadKey();
        }
    }
}
