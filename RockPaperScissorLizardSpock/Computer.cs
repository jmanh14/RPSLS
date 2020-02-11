using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class Computer : Player
    {
        Random rnd = new Random();

        public Computer()
        {
            name = "Computer";
        }

        public override string ChooseMove(int move)
        {
             int rnd = new Random().Next(1, 6);
            Console.WriteLine($"Computer chose {gestures[rnd - 1].move}");
            return gestures[rnd - 1].move;
        }

    }
}
