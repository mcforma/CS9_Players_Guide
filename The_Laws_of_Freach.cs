using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_Guide
{
    internal class The_Laws_of_Freach
    {
        public static void Freach()
        {
            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

            int currentMinimum = int.MaxValue;
            foreach(int i in array)
            {
                if(i < currentMinimum)
                    currentMinimum = i;
            }

            Console.WriteLine(currentMinimum);

            int total = 0;
            foreach(int i in array)
            {
                total += i;
            }

            float average = (float)total / array.Length;
            Console.WriteLine(average);
        }
    }
}
