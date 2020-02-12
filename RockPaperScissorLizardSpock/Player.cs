using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    public abstract class Player
    {
        public string name;
        public List<Gesture> gestures;
        public string gesture;
        public int score = 0;
        public Player()
        {
            score = 0;
            gestures = new List<Gesture>() { new Gesture("Rock"), new Gesture("Paper"), new Gesture("Scissors"), new Gesture("Lizard"), new Gesture("Spock") };
        }

        public abstract void ChooseMove();
        public abstract void GetName();
       

    }
}
