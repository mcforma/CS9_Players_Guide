using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_Guide
{
    internal class Repairing_the_Clocktower
    {
        public static void Tick_or_Tock()
        {
            int clock_num = 0;

            Console.Write("Please enter an integer: ");
            clock_num = Convert.ToInt32(Console.ReadLine());

            if (clock_num % 2 == 0)
                Console.WriteLine("Tick");
            else if (clock_num % 2 == 1)
                Console.WriteLine("Tock");
        }
    }
}
