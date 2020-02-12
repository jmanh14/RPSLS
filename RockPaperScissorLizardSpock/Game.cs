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

        private int GetNumberOfPlayers()
        {
            Console.WriteLine("Would you like to play [1]Single Player or [2]Multiplayer");
            Console.Write(">> ");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
            return choice;
        }
      
        private void SetPlayers(int numOfPlayers)
        {
            if (numOfPlayers == 1)
            {
                playerOne = new Human();
                playerTwo = new Computer();
            }
            else if (numOfPlayers == 2)
            {
                playerOne = new Human();
                playerTwo = new Human();
            }
            else
            {
                Console.WriteLine("There are only 2 game modes!");
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
                PlayGame();
            }
        }
        private void DisplayRules()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Rules");
            Console.WriteLine("================================");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Rock crushes Scissors");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Scissors cuts Paper");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Paper covers Rock");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Rock crushes Lizard");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Lizard poisons Spock");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Spock smashes Scissors");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Scissors decapitates Lizard");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Lizard eats Paper");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Paper disproves Spock");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Spock vaporizes Rock");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
            Console.ResetColor();
        }

        private void DisplayScore()
        {
            Console.WriteLine($"{playerOne.name} vs {playerTwo.name}");
            Console.WriteLine("=======================");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{playerOne.score} - {playerTwo.score}");
            Console.ResetColor();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
        }
        public void PlayGame()
        {
            string yesOrNo = "y";
            DisplayRules();
            while (yesOrNo == "y" || yesOrNo == "Y")
            { 
                int players = GetNumberOfPlayers();
                SetPlayers(players);
                playerOne.GetName();
                playerTwo.GetName();
                while (playerOne.score < 3 && playerTwo.score < 3)
                {
                    Console.Clear();
                    DisplayScore();
                    playerOne.ChooseMove();
                    playerTwo.ChooseMove();
                    Console.WriteLine($"{playerOne.name} chose {playerOne.gesture}");
                    Console.WriteLine($"{playerTwo.name} chose {playerTwo.gesture}");
                    CompareMoves(playerOne.gesture, playerTwo.gesture);
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();   
                }
                if (playerOne.score == 3)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{playerOne.name} wins {playerOne.score} - {playerTwo.score}");
                    Console.ResetColor();
                }
                else if (playerTwo.score == 3)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{playerTwo.name} wins {playerOne.score} - {playerTwo.score}");
                    Console.ResetColor();
                }
                Console.WriteLine("Play again? [Y/N]");
                Console.Write(">> ");
                yesOrNo = Console.ReadLine();
            }
        }

        private void CompareMoves(string humanMove, string computerMove)
        {
           //Rock crushes scissors
           if ((humanMove == "Rock" && computerMove == "Scissors") || (computerMove == "Rock" && humanMove == "Scissors"))
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Rock crushes Scissors");
                if (humanMove == "Rock")
                {
                    playerOne.score++;
                }
                else
                {
                    playerTwo.score++;
                }
                
            }
            //Scissors cuts paper
            else if ((humanMove == "Scissors" && computerMove == "Paper") || (computerMove == "Scissors" && humanMove == "Paper"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Scissors cuts Paper");
                if (humanMove == "Scissors")
                {
                    playerOne.score++;
                }
                else
                {
                    playerTwo.score++;
                }
            }
            //Paper covers rock
            else if ((humanMove == "Paper" && computerMove == "Rock") || (computerMove == "Paper" && humanMove == "Rock"))
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Paper covers Rock");
                if (humanMove == "Paper")
                {
                    playerOne.score++;
                }
                else
                {
                    playerTwo.score++;
                }
            }
            //Rock crushes lizard
            else if ((humanMove == "Rock" && computerMove == "Lizard") || (computerMove == "Rock" && humanMove == "Lizard"))
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Rock crushes Lizard");
                if (humanMove == "Rock")
                {
                    playerOne.score++;
                }
                else
                {
                    playerTwo.score++;
                }
            }
            //Lizard poisons spock
            else if ((humanMove == "Lizard" && computerMove == "Spock") || (computerMove == "Lizard" && humanMove == "Spock"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Lizard poisons Spock");
                if (humanMove == "Lizard")
                {
                    playerOne.score++;
                }
                else
                {
                    playerTwo.score++;
                }
            }
            //Spock smashes scissors
            else if ((humanMove == "Spock" && computerMove == "Scissors") || (computerMove == "Spock" && humanMove == "Scissors"))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Spock smashes Scissors");
                if (humanMove == "Spock")
                {
                    playerOne.score++;
                }
                else
                {
                    playerTwo.score++;
                }
            }
            //Scissors decapitates lizard
            else if ((humanMove == "Scissors" && computerMove == "Lizard") || (computerMove == "Scissors" && humanMove == "Lizard"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Scissors decapitates Lizard");
                if (humanMove == "Scissors")
                {
                    playerOne.score++;
                }
                else
                {
                    playerTwo.score++;
                }
            }
            //Lizard eats paper
            else if ((humanMove == "Lizard" && computerMove == "Paper") || (computerMove == "Lizard" && humanMove == "Paper"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Lizard eats Paper");
                if (humanMove == "Lizard")
                {
                    playerOne.score++;
                }
                else
                {
                    playerTwo.score++;
                }
            }
            //Paper disproves Spock
            else if ((humanMove == "Paper" && computerMove == "Spock") || (computerMove == "Paper" && humanMove == "Spock"))
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Paper disproves Spock");
                if (humanMove == "Paper")
                {
                    playerOne.score++;
                }
                else
                {
                    playerTwo.score++;
                }
            }
            //Spock vaporizes Rock
            else if ((humanMove == "Spock" && computerMove == "Rock") || (computerMove == "Spock" && humanMove == "Rock"))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Spock vaporizes Rock");
                if (humanMove == "Spock")
                {
                    playerOne.score++;
                }
                else
                {

                    playerTwo.score++;
                }
            }
           else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("TIE!?!");
            }
            Console.ResetColor();
        }
      
    }
}
