using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_Guide
{
    internal class Simulas_Soup
    {
        public static void Soup_Maker()
        {
            (Food_Type Food_Types, Main_Ingredient Main_Ingredients, Seasoning Seasonings)[] foods = new (Food_Type, Main_Ingredient, Seasoning)[3];
            
            for(int i = 0; i < foods.Length; i++)
            {
                do
                {
                    Console.Write($"Please choose a food type ({Food_Type.Soup}, {Food_Type.Stew}, {Food_Type.Gumbo}) for food {i+1}: ");
                    Enum.TryParse(Console.ReadLine(), out foods[i].Food_Types);
                }
                while (foods[i].Food_Types != Food_Type.Soup && foods[i].Food_Types != Food_Type.Stew && foods[i].Food_Types != Food_Type.Gumbo);

                do
                {
                    Console.Write($"Please choose the main ingredient ({Main_Ingredient.Mushroom}, {Main_Ingredient.Chicken}, {Main_Ingredient.Carrot}, {Main_Ingredient.Potato}) for food {i + 1}: ");
                    Enum.TryParse(Console.ReadLine(), out foods[i].Main_Ingredients);
                }
                while (foods[i].Main_Ingredients != Main_Ingredient.Chicken && foods[i].Main_Ingredients != Main_Ingredient.Potato && foods[i].Main_Ingredients != Main_Ingredient.Carrot && foods[i].Main_Ingredients != Main_Ingredient.Mushroom);

                do
                {
                    Console.Write($"Please choose the seasoning ({Seasoning.Spicy}, {Seasoning.Salty}, {Seasoning.Sweet}) for food {i + 1}: ");
                    Enum.TryParse(Console.ReadLine(), out foods[i].Seasonings);
                }
                while (foods[i].Seasonings != Seasoning.Spicy && foods[i].Seasonings != Seasoning.Salty && foods[i].Seasonings != Seasoning.Sweet);

                Console.WriteLine();
            }

            for(int i = 0; i < foods.Length;i++)
            {
                Console.WriteLine($"{i+1}: {foods[i].Seasonings} {foods[i].Main_Ingredients} {foods[i].Food_Types}");
            }
        }

        // Assign first enum members 1 so that the first enum members are not assigned as 0 and therefore selected as defaults during enum try parsing, since
        // try parsing into an enum where the string does not match one of the enum members will result in parsing into the default if a default is defined.
        // Therefore we intentionally do not define a default, thereby forcing the user to input one of the exact enumeration members' names (or corresponding integers theoretically)
        enum Food_Type { Soup = 1, Stew, Gumbo }
        enum Main_Ingredient { Mushroom = 1, Chicken, Carrot, Potato }
        enum Seasoning { Spicy = 1, Salty, Sweet }
    }
}
