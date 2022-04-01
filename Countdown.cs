using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_Guide
{
    internal class Countdown
    {
        public static void CountingDown(int num)
        {
            if (num == 0) return;

            Console.WriteLine(num);
            CountingDown(num - 1);
        }
    }
}
