using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_Guide
{
    internal class Simulas_Test
    {

        public static void Chest_State()
        {
            bool check = true;
            Chest small_chest = Chest.Locked;
            
            while(check)
            {
                Console.Write($"The chest is {small_chest}. What do you want to do?  ");
                Enum.TryParse(Console.ReadLine(), out Action action);
                if (small_chest == Chest.Locked && action == Action.Unlock) small_chest = Chest.Closed;
                else if (small_chest == Chest.Closed && action == Action.Open) small_chest = Chest.Opened;
                else if (small_chest == Chest.Opened && action == Action.Close) small_chest= Chest.Closed;
                else if (small_chest == Chest.Closed && action ==Action.Lock) small_chest= Chest.Locked;
            }



            
        }

        enum Chest { Opened, Closed, Locked }
        enum Action {Lock, Unlock, Open, Close}
    }
}
