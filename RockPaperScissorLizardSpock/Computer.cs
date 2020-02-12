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

        }

        public override void ChooseMove()
        {
             int rnd = new Random().Next(1, 6);
            gesture = gestures[rnd - 1].move;
        }

        public override void GetName()
        {
            name = "Computer";
        }

    }
}
