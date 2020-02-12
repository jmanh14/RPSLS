using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class Human : Player
    { 
        public Human()
        {
            name = "Human";
        }
        public override void ChooseMove()
        {
            //Console.Clear();
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine($"[{i + 1}]{gestures[i].move}");
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Choose a gesture, {name}: ");
            Console.Write(">> ");
            gesture = Console.ReadLine();
            if ((int.Parse(gesture) <= 5 && int.Parse(gesture) > 0)) 
            {
                gesture = gestures[int.Parse(gesture) - 1].move;
            }
            else
            {
                Console.WriteLine("Not a valid gesture");
                ChooseMove();
            }
            
            
        }
        public override void GetName()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock");
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            if (name == null)
            {
                Console.WriteLine("Sorry couldn't catch that..");
            }
            else
            {

                Console.WriteLine($"Hello {name}.");
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
            }
        }


    }
}
