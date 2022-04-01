using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_Guide
{
    internal class The_Triangle_Farmer
    {
        public static void Calc_Area_of_Triangle()
        {
            double triangle_base;
            double triangle_height;
            double triangle_area;

            Console.WriteLine("Please provide the triangle's base: ");
            triangle_base = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please provide the triangle's height: ");
            triangle_height = Convert.ToInt32(Console.ReadLine());

            triangle_area = triangle_base * triangle_height / 2;

            Console.WriteLine($"For a triangle with a base of {triangle_base}, and a height of {triangle_height}, the area is: {triangle_area}");

        }
    }
}
