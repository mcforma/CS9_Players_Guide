using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_Guide
{
    internal class Buying_Inventory
    {
        public static void Price_List()
        {
            int choice = 0;
            double cost = 0;
            string name = null;

            Console.WriteLine("The following items are available: ");
            Console.WriteLine("1 - Ropes" +
                "\n2 - Torches" +
                "\n3 - Climbing Equipment" +
                "\n4 - Clean Water" +
                "\n5 - Machete" +
                "\n6 - Canoe" +
                "\n7 - Food Supplies" +
                "\n0 - To exit");
            Console.Write("\nWhat is the number of the item you would like to see the price of? ");
            //choice = Convert.ToInt32(Console.ReadLine());

            //Console.Write("\nWhat is your name? ");
            //name = Console.ReadLine();

            //while (String.IsNullOrEmpty(name))
            //{
            //    Console.Write("Please enter your name: ");
            //    name = Console.ReadLine();
            //}


            //switch(choice)
            //{
            //    case 0: break;
            //    case 1:
            //        cost = 10;
            //        if (name == "Matt" || name == "Matthew")
            //            cost /= 2;
            //        Console.WriteLine($"Rope costs {cost} gold.");
            //        break;
            //    case 2:
            //        cost = 15;
            //        if (name == "Matt" || name == "Matthew")
            //            cost /= 2;
            //        Console.WriteLine($"Torches cost {cost} gold.");
            //        break;
            //    case 3:
            //        cost = 25;
            //        if (name == "Matt" || name == "Matthew")
            //            cost /= 2;
            //        Console.WriteLine($"Climbing Equipment costs {cost} gold.");
            //        break;
            //    case 4:
            //        cost = 1;
            //        if (name == "Matt" || name == "Matthew")
            //            cost /= 2;
            //        Console.WriteLine($"Clean Water costs {cost} gold.");
            //        break;
            //    case 5:
            //        cost = 20;
            //        if (name == "Matt" || name == "Matthew")
            //            cost /= 2;
            //        Console.WriteLine($"A machete costs {cost} gold.");
            //        break;
            //    case 6:
            //        cost = 200;
            //        if (name == "Matt" || name == "Matthew")
            //            cost /= 2;
            //        Console.WriteLine($"A canoe costs {cost} gold.");
            //        break;
            //    case 7:
            //        cost = 1;
            //        if (name == "Matt" || name == "Matthew")
            //            cost /= 2;
            //        Console.WriteLine($"Food supplies cost {cost} gold.");
            //        break;
            //}


            int itemNumber = Convert.ToInt32(Console.ReadLine());
            string item = itemNumber switch
            {
                1 => "Rope",
                2 => "Torches",
                3 => "Climbing Equipment",
                4 => "Clean water",
                5 => "Machete",
                6 => "Canoe",
                7 => "Food Supplies"
            };

            double price = item switch
            {
                "Rope" => 10,
                "Torches" => 15,
                "Climbing Equipment" => 25,
                "Clean water" => 1,
                "Machete" => 20,
                "Canoe" => 200,
                "Food Supplies" => 1
            };

            Console.Write("What is your name? ");
            string name2 = Console.ReadLine();

            if (name2 == "Matt" || name2 == "Matthew")
                price /= 2;

            Console.WriteLine($"{item} costs {price} gold.");
        }
    }
}
