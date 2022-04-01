using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_Guide
{
    internal class The_Prototype
    {
        public static void Hunt_Num_Guess() 
        {
            
            int user2_guess = -1;

            int user1_num = AskForNumber.AskForNumberInRange("User 1, enter an integer between 0 and 100: ", 0, 100);
            //while(user1_num < 0 || user1_num > 100)
            //{
            //    Console.Write("User 1, enter an integer between 0 and 100: ");
            //    user1_num = Convert.ToInt32(Console.ReadLine());
            //    if (user1_num < 0 || user1_num > 100) Console.WriteLine("The number you selected is not within range");
            //}


            Console.Clear();
            Console.WriteLine("User 2, guess the number.");

            do
            {
                Console.Write("What is your next guess? ");
                user2_guess = Convert.ToInt32(Console.ReadLine());

                if (user2_guess > user1_num) Console.WriteLine($"{user2_guess} is too high.");
                else if (user2_guess < user1_num) Console.WriteLine($"{user2_guess} is too low.");
                else if (user2_guess == user1_num) Console.WriteLine("You guessed the correct number!");
            }
            while (user2_guess != user1_num);

        }
    }
}
