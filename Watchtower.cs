using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_Guide
{
    internal class Watchtower
    {
        public static void Enemy_Location()
        {
            double x_coordinate, y_coordinate;

            Console.WriteLine("Please enter the coordinates of the enemy");
            Console.Write("Enter the x coordinate: ");
            x_coordinate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the y coordinate: ");
            y_coordinate = Convert.ToDouble(Console.ReadLine());

            if (x_coordinate < 0)
                if (y_coordinate < 0) Console.WriteLine("The enemy is to the southwest!");
                else if (y_coordinate == 0) Console.WriteLine("The enemy is to the west!");
                else if (y_coordinate > 0) Console.WriteLine("The enemy is to the northwest!");
                else Console.WriteLine();
            else if (x_coordinate == 0)
                if (y_coordinate < 0) Console.WriteLine("The enemy is to the south!");
                else if (y_coordinate == 0) Console.WriteLine("The enemy is here!");
                else if (y_coordinate > 0) Console.WriteLine("The enemy is to the north!");
                else Console.WriteLine();
            else if (x_coordinate > 0)
                if (y_coordinate < 0) Console.WriteLine("The enemy is to the southeast!");
                else if (y_coordinate == 0) Console.WriteLine("The enemy is to the east!");
                else if (y_coordinate > 0) Console.WriteLine("The enemy is to the northeast!");
                


        }
    }
}
