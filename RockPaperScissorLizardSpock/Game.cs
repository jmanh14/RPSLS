using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    public class Game
    {
        public Player playerOne;
        public Player playerTwo;

        public void Intro()
        { 
            int choice;
            GetName();
            playerOne = new Human();
            Console.WriteLine("Would you like to play [1]Single Player or [2]Multiplayer");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                PlayGame(choice);
            }
            else if (choice == 2)
            {
                PlayGame(choice);
            }
            else
            {
                Console.WriteLine("Invalid input");
                Console.WriteLine("Would you like to play [1]Single Player or [2]Multiplayer");
                choice = int.Parse(Console.ReadLine());
            }
        }
        public void GetName()
        {
            string name;
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
            }
        }
        public void GetMove()
        {
            for (int i = 0; i < playerOne.gestures.Count; i++)
            {
                Console.WriteLine($"[{i + 1}]{playerOne.gestures[i].move}");
            }
            Console.WriteLine("Enter your move");
            Console.Write(">> ");
        }
        public void PlayGame(int selection)
        {
            if (selection == 1)
            {
                playerTwo = new Computer();
            }
            else
            {
                GetName();
                playerTwo = new Human();
                GetMove();
                int playerTwoChoice = int.Parse(Console.ReadLine());
            }
            string humanMove;
            string computerMove;
            //Console.Clear();
            GetMove();
            int playerOneChoice = int.Parse(Console.ReadLine());
            humanMove = playerOne.ChooseMove(playerOneChoice);
            computerMove = playerTwo.ChooseMove(playerOneChoice);
            CompareMoves(humanMove, computerMove);
            Console.ReadLine();
            
        }

        public void CompareMoves(string humanMove, string computerMove)
        {
           //Rock crushes scissors
           if ((humanMove == "Rock" && computerMove == "Scissors") || (computerMove == "Rock" && humanMove == "Scissors"))
            {
                if (humanMove == "Rock")
                {
                    Console.WriteLine($"{humanMove} crushes {computerMove}");
                    playerOne.score++;
                }
                else
                {
                    Console.WriteLine($"{computerMove} crushes {humanMove}");
                }
                
            }
            //Scissors cuts paper
            else if ((humanMove == "Scissors" && computerMove == "Paper") || (computerMove == "Scissors" && humanMove == "Paper"))
            {
                Console.WriteLine("Scissors cuts paper");
            }
            //Paper covers rock
            else if ((humanMove == "Paper" && computerMove == "Rock") || (computerMove == "Paper" && humanMove == "Rock"))
            {
                Console.WriteLine("Paper covers rock");
            }
            //Rock crushes lizard
            else if ((humanMove == "Rock" && computerMove == "Lizard") || (computerMove == "Rock" && humanMove == "Lizard"))
            {
                Console.WriteLine("Rock crushes lizard");
            }
            //Lizard poisons spock
            else if ((humanMove == "Lizard" && computerMove == "Spock") || (computerMove == "Lizard" && humanMove == "Spock"))
            {
                Console.WriteLine("Lizard poisons Spock");
            }
            //Spock smashes scissors
            else if ((humanMove == "Spock" && computerMove == "Scissors") || (computerMove == "Spock" && humanMove == "Scissors"))
            {
                Console.WriteLine("Spock smashes scissors");
            }
            //Scissors decapitates lizard
            else if ((humanMove == "Scissors" && computerMove == "Lizard") || (computerMove == "Scissors" && humanMove == "Lizard"))
            {
                Console.WriteLine("Scissors decapitates lizard");
            }
            //Lizard eats paper
            else if ((humanMove == "Lizard" && computerMove == "Paper") || (computerMove == "Lizard" && humanMove == "Paper"))
            {
                Console.WriteLine("Lizard eats paper");
            }
            //Paper disproves Spock
            else if ((humanMove == "Paper" && computerMove == "Spock") || (computerMove == "Paper" && humanMove == "Spock"))
            {
                Console.WriteLine("Paper disproves Spock");
            }
            //Spock vaporizes Rock
            else if ((humanMove == "Spock" && computerMove == "Rock") || (computerMove == "Spock" && humanMove == "Rock"))
            {
                Console.WriteLine("Spock vaporizes rock");
            }
           else
            {
                Console.WriteLine("TIE!?!");
            }
        }
    }
}
