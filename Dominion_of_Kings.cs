using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_Guide
{
    internal class Dominion_of_Kings
    {
        public static void Kingdom_Quantifier()
        {
            int estates = 0;
            int duchies = 0;
            int provinces = 0;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "C# Player's Guide";

            Console.WriteLine("How many estates do you have in your Kingdom?");
            estates = Convert.ToInt32(Console.ReadLine());
       
            Console.WriteLine("How many duchies do you have in your Kingdom?");
            duchies = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many provinces do you have in your Kingdom?");
            provinces = Convert.ToInt32(Console.ReadLine());

            int estate_points = estates * 1;
            int duchy_points = duchies * 3;
            int province_points = provinces * 6;
            int total = estate_points + duchy_points + province_points;

            Console.WriteLine($"Based on the kingdom rating system, your kingdom has {total} total points.");          


        }
    }
}
