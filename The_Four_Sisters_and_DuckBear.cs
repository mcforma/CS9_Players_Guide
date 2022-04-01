using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_Guide
{
    internal class The_Four_Sisters_and_DuckBear
    {

        public static void EggDivider()
        {
            int total_eggs;
            int eggs_per_sister = 0;
            const int sisters = 4;
            int eggs_for_Duckbear = 0;

            Console.WriteLine("Please enter the total number of chocolate eggs collected today: ");
            total_eggs = Convert.ToInt32(Console.ReadLine());

            eggs_per_sister = total_eggs / sisters;
            eggs_for_Duckbear = total_eggs % sisters;

            Console.WriteLine($"Each of the sisters get {eggs_per_sister} chocolate eggs, and {eggs_for_Duckbear} are left over for their duckbear");
        }
    }
}
