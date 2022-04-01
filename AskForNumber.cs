using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_Guide
{
    internal class AskForNumber
    {
        public static int AskForNumber1(string text)
        { 
            int response = 0;

            Console.WriteLine(text);
            response = Convert.ToInt32(Console.ReadLine());

            return response;
        }

        public static int AskForNumberInRange(string text, int min, int max)
        {
            int input = 0;
            Console.WriteLine(text);

            input = Convert.ToInt32(Console.ReadLine());
            if (input < min || input > max)
            {
                Console.WriteLine("That number is out of range.");
                AskForNumberInRange(text, min, max);
            }
            else if (input >= min && input <= max) return input;

            return input;
        }
    }
}
