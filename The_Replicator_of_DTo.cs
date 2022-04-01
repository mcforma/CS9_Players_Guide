using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_Guide
{
    internal class The_Replicator_of_DTo
    {
        public static void Replicator()
        {
            int[] array1 = new int[5];

            for(int i = 0; i < array1.Length; i++)
            {
                Console.Write($"Please enter an integer for index {i}: ");
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] arrayCopy = new int[5]; 

            for(int i = 0; i < arrayCopy.Length; i++)
            {
                arrayCopy[i] = array1[i];
            }

            for(int i = 0; i < arrayCopy.Length; i++)
            {
                Console.WriteLine($"{array1[i]} and {arrayCopy[i]}");
            }
        }


    }
}
