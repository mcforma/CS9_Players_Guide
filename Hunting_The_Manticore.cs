using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_Guide
{
    internal class Hunting_The_Manticore
    {
        public static void Play_Game()
        {
            int distance_from_city = -1;
            int manticore_health = 10;
            int city_health = 15;
            int round = 1;
            int cannon_damage = 0;
            int cannon_range = -1;

            Console.Write("Player 1, how far away from the city do you want to station the Manticore (0 to 100)?  ");
            distance_from_city = Distance();
            Console.Clear();

            Console.WriteLine("Player 2, it is your turn.");


            while(manticore_health > 0 && city_health > 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"STATUS: Round: {round}  City: {city_health}/15  Manticore: {manticore_health}/10");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"The cannon is expected to deal {cannon_damage = Cannon_Damage(round)} damage this round.");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"Enter desired cannon range: ");

                cannon_range = Distance();
                Hit_Or_Miss(cannon_range, distance_from_city);


                if (cannon_range == distance_from_city) manticore_health -= cannon_damage;
                if (manticore_health > 0) city_health--;               

                round++;
                Console.WriteLine();
            }

            DisplayWinOrLose(manticore_health, city_health);
        }

        public static int Distance()
        {
            int distance = -1;

            do
            {
                distance = Convert.ToInt32(Console.ReadLine());
                if (distance < 0 || distance > 100) 
                    Console.WriteLine("That number is not within range, please enter an integer between 0 and 100.");
            }
            while (distance < 0 || distance > 100);

            return distance;
        }

        public static int Cannon_Damage(int round)
        {
            int cannon_damage = 0;

            if (round % 3 == 0 && round % 5 != 0) cannon_damage = 3;
            else if (round % 5 == 0 && round % 3 != 0) cannon_damage = 3;
            else if (round % 3 == 0 && round % 5 == 0) cannon_damage = 10;
            else cannon_damage = 1;

            return cannon_damage;
        }

        public static void Hit_Or_Miss(int cannon_range, int manticore_distance)
        {

            if (cannon_range < manticore_distance) Console.WriteLine("That round FELL SHORT of the target.");
            else if (cannon_range > manticore_distance) Console.WriteLine("That round OVERSHOT the target.");
            else Console.WriteLine("That round was a DIRECT HIT!");

        }

        public static void DisplayWinOrLose(int manticore_hp, int city_hp)
        {
            if (manticore_hp <= 0) Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
            else if (city_hp <= 0) Console.WriteLine("The city of Consolas has been destroyed! The Manticore and the Uncoded One have prevailed!");

        }
    }
}
