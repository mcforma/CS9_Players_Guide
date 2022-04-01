using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Arrow;

//namespace Player_Guide
//{

Arrow arrow = Get_Arrow();
Console.WriteLine($"That arrow costs {arrow.Get_Cost()} gold.");


Arrow Get_Arrow()
    {
        _Arrowhead arrowhead = Get_Arrowhead_Type();
        _Fletching  fletching = Get_Fletching_Type();
        float length = Get_Length();

        return new Arrow(arrowhead, fletching, length);
    }


    // Get arrowhead material
    _Arrowhead Get_Arrowhead_Type()
    {
        string input; //initiate input as null
        do // do while loops at least once
        {
            input = null; // set as null again in case do while loops so that program will enter while loop and ask for material again.

            while (String.IsNullOrWhiteSpace(input)) // Check to ensure string is not null, empty or white space. This also causes
                                                     // while loop to enter since input was intentionally set to null
            {
                //List material choices
                Console.Write("\nPlease choose the arrowhead material (wood, obsidian, or steel): ");
                input = Console.ReadLine(); //loop while null, empty, or white space.
            }
            input = input.ToLower(); // return string in lower case

            if (input != "wood" && input != "obsidian" && input != "steel")
            {
                Console.Write("\nThat input is invalid.");
            }
        }
        while (input != "wood" && input != "obsidian" && input != "steel"); // While input is not wood, obsidian or steel, loop

        return input switch //use switch expression to return correct _Arrowhead member
        {
            "wood" => _Arrowhead.Wood,
            "obsidian" => _Arrowhead.Obsidian,
            "steel" => _Arrowhead.Steel
        };
    }



    // Get fletching material
    static _Fletching Get_Fletching_Type()
    {
        string input;
        do
        {
            input = null;

            while (String.IsNullOrWhiteSpace(input))
            {
                Console.Write("\nPlease choose the fletching material (goose feathers, turkey feathers, or plastic): ");
                input = Console.ReadLine();
            }
            input = input.ToLower();

            if (input != "goose feathers" && input != "turkey feathers" && input != "plastic")
            {
                Console.Write("\nThat input is invalid.");
            }
        }
        while (input != "goose feathers" && input != "turkey feathers" && input != "plastic");

        return input switch
        {
            "goose feathers" => _Fletching.Goose_Feather,
            "turkey feathers" => _Fletching.Turkey_Feather,
            "plastic" => _Fletching.Plastic
        };
    }



    // Get arrow shaft length
    static float Get_Length()
    {
        string input;
        float length = 0.0f;

        do
        {
            input = null;
            while (String.IsNullOrWhiteSpace(input))
            {
                Console.Write("\nPlease enter the arrow shaft length in centimeters (at least 60, no more than 100): ");
                input = Console.ReadLine();
            }
            length = float.Parse(input);

            if (length < 60 && length > 100)
            {
                Console.WriteLine("Invalid input.");
            }
        }
        while (length < 60 && length > 100);

        return length;
    }

    class Arrow
    {
        public static _Arrowhead _arrowhead;
        public static _Fletching _fletching;
        public static float _length;

        // Constructor
        public Arrow(_Arrowhead arrowhead, _Fletching fletching, float length)
        {
            _arrowhead = arrowhead;
            _fletching = fletching;
            _length = length;
        }

        // Get cost
        public float Get_Cost()
        {
            float a_cost = 0.0f;
            float f_cost = 0.0f;
            float s_cost = 0.0f;
            const float len_rate = .05f;
            float total = 0.0f; 

            if (Arrow._arrowhead == _Arrowhead.Wood)
                a_cost = 3;
            else if (Arrow._arrowhead == _Arrowhead.Obsidian)
                a_cost = 5;
            else if (Arrow._arrowhead == _Arrowhead.Steel)
                a_cost = 10;
            else
            {
                a_cost = -1;
                throw new Exception("Invalid arrowhead");
            }

            if (Arrow._fletching == _Fletching.Goose_Feather)
                f_cost = 3;
            else if (Arrow._fletching == _Fletching.Turkey_Feather)
                f_cost = 5;
            else if (Arrow._fletching == _Fletching.Plastic)
                f_cost = 10;
            else
            {
                f_cost = -1;
                throw new Exception("Invalid fletching");
            }

            s_cost = Arrow._length * len_rate;
            total = a_cost + f_cost + s_cost;

            return total;
        }






        // Enums for arrowhead and fletching materials
        public enum _Arrowhead { Wood = 3, Obsidian = 5, Steel = 10}
        public enum _Fletching { Goose_Feather = 3, Turkey_Feather = 5, Plastic = 10}
    }
//}

