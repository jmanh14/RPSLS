using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class Computer : Player
    {
        Random rnd;

        public Computer(Random Rng)
        {
            rnd = Rng;   
        }

        public override void ChooseMove()
        {
            int rnd = this.rnd.Next(1, 6);
            gesture = gestures[rnd -1].move;
        }

        public override void GetName()
        {
            name = "Computer";
        }

    }
}
