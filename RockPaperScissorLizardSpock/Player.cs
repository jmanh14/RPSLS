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
        public Gesture gesture;
        public int score;
        public Player()
        {
            score = 0;
            gestures = new List<Gesture>() { new Gesture("Rock"), new Gesture("Paper"), new Gesture("Scissors"), new Gesture("Lizard"), new Gesture("Spock") };
        }

        public virtual string ChooseMove(int move)
        {          
            Console.WriteLine($"Player chose {gestures[move-1].move}");
            return gestures[move - 1].move;
        }

    }
}
