using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_Guide
{
    internal class The_Defense_of_Consolas
    {
        public static void Move_Magical_Barrier()
        {
            int target_row = 0;
            int target_col = 0;

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Enter the coordinates for the next assault.");

            while (target_row <= 0 || target_row >= 9)
            {
                Console.Write("Target Row: ");
                target_row = Convert.ToInt32(Console.ReadLine());

                if (target_row <= 0 || target_row >= 9)
                    Console.WriteLine("The supplied row is out of range. Please enter a row between 1 and 8");
            }

            while (target_col <= 0 || target_col >= 9)
            {
                Console.Write("Target Column: ");
                target_col = Convert.ToInt32(Console.ReadLine());

                if (target_col <= 0 || target_col >= 9)
                    Console.WriteLine("The supplied column is out of range. Please enter a column between 1 and 8");
            }

            Console.WriteLine("Deploy to: ");
            Console.WriteLine($"({target_row}, {target_col - 1})");
            Console.WriteLine($"({target_row - 1}, {target_col})");
            Console.WriteLine($"({target_row}, {target_col + 1})");
            Console.WriteLine($"({target_row + 1}, {target_col})");

            Console.Beep();





        }
    }
}
