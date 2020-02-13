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
            try
            {
                int choice = int.Parse(Console.ReadLine());
                Console.Clear();
                return choice;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Try again");
                Console.Write(">> ");
                return GetNumberOfPlayers();
            }
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
                Console.WriteLine("There are only 3 game modes!");
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
            Console.WriteLine("\n\nSelect from the list. Best Of 3! Good Luck!");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
            Console.ResetColor();
        }

        private void DisplayScore()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{playerOne.name} vs {playerTwo.name}");
            Console.WriteLine("=======================");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{playerOne.score} - {playerTwo.score}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
        }

        private void DisplayChoice()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{playerOne.name} chose {playerOne.gesture}");
            Console.WriteLine($"{playerTwo.name} chose {playerTwo.gesture}");
        }
        private void DisplayWinner() 
        {
            if (playerOne.score == 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{playerOne.name} wins {playerOne.score} - {playerTwo.score}");
                Console.ResetColor();
            }
            else if (playerTwo.score == 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{playerTwo.name} wins {playerOne.score} - {playerTwo.score}");
                Console.ResetColor();
            }
        }
        public void PlayGame()
        {
            string yesOrNo = "y";
            DisplayRules();
            while (yesOrNo == "y" || yesOrNo == "Y")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                int players = GetNumberOfPlayers();
                SetPlayers(players);
                playerOne.GetName();
                playerTwo.GetName();
                while (playerOne.score < 3 && playerTwo.score < 3)
                {              
                    DisplayScore();
                    playerOne.ChooseMove();
                    DisplayScore();
                    playerTwo.ChooseMove();
                    DisplayScore();
                    DisplayChoice();
                    CompareMoves(playerOne.gesture, playerTwo.gesture);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();   
                }
                Console.Clear();
                DisplayWinner();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Play again? [Y/N]");
                Console.Write(">> ");
                yesOrNo = Console.ReadLine();
            }
        }

        private void CompareMoves(string playerOneMove, string playerTwoMove)
        {
           //Rock crushes scissors
           if ((playerOneMove == "Rock" && playerTwoMove == "Scissors") || (playerTwoMove == "Rock" && playerOneMove == "Scissors"))
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Rock crushes Scissors");
                if (playerOneMove == "Rock")
                {
                    playerOne.score++;
                }
                else
                {
                    playerTwo.score++;
                }
                
            }
            //Scissors cuts paper
            else if ((playerOneMove == "Scissors" && playerTwoMove == "Paper") || (playerTwoMove == "Scissors" && playerOneMove == "Paper"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Scissors cuts Paper");
                if (playerOneMove == "Scissors")
                {
                    playerOne.score++;
                }
                else
                {
                    playerTwo.score++;
                }
            }
            //Paper covers rock
            else if ((playerOneMove == "Paper" && playerTwoMove == "Rock") || (playerTwoMove == "Paper" && playerOneMove == "Rock"))
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Paper covers Rock");
                if (playerOneMove == "Paper")
                {
                    playerOne.score++;
                }
                else
                {
                    playerTwo.score++;
                }
            }
            //Rock crushes lizard
            else if ((playerOneMove == "Rock" && playerTwoMove == "Lizard") || (playerTwoMove == "Rock" && playerOneMove == "Lizard"))
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Rock crushes Lizard");
                if (playerOneMove == "Rock")
                {
                    playerOne.score++;
                }
                else
                {
                    playerTwo.score++;
                }
            }
            //Lizard poisons spock
            else if ((playerOneMove == "Lizard" && playerTwoMove == "Spock") || (playerTwoMove == "Lizard" && playerOneMove == "Spock"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Lizard poisons Spock");
                if (playerOneMove == "Lizard")
                {
                    playerOne.score++;
                }
                else
                {
                    playerTwo.score++;
                }
            }
            //Spock smashes scissors
            else if ((playerOneMove == "Spock" && playerTwoMove == "Scissors") || (playerTwoMove == "Spock" && playerOneMove == "Scissors"))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Spock smashes Scissors");
                if (playerOneMove == "Spock")
                {
                    playerOne.score++;
                }
                else
                {
                    playerTwo.score++;
                }
            }
            //Scissors decapitates lizard
            else if ((playerOneMove == "Scissors" && playerTwoMove == "Lizard") || (playerTwoMove == "Scissors" && playerOneMove == "Lizard"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Scissors decapitates Lizard");
                if (playerOneMove == "Scissors")
                {
                    playerOne.score++;
                }
                else
                {
                    playerTwo.score++;
                }
            }
            //Lizard eats paper
            else if ((playerOneMove == "Lizard" && playerTwoMove == "Paper") || (playerTwoMove == "Lizard" && playerOneMove == "Paper"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Lizard eats Paper");
                if (playerOneMove == "Lizard")
                {
                    playerOne.score++;
                }
                else
                {
                    playerTwo.score++;
                }
            }
            //Paper disproves Spock
            else if ((playerOneMove == "Paper" && playerTwoMove == "Spock") || (playerTwoMove == "Paper" && playerOneMove == "Spock"))
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Paper disproves Spock");
                if (playerOneMove == "Paper")
                {
                    playerOne.score++;
                }
                else
                {
                    playerTwo.score++;
                }
            }
            //Spock vaporizes Rock
            else if ((playerOneMove == "Spock" && playerTwoMove == "Rock") || (playerTwoMove == "Spock" && playerOneMove == "Rock"))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Spock vaporizes Rock");
                if (playerOneMove == "Spock")
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
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("TIE!?!");
            }
            Console.ResetColor();
        }       
    }
}
