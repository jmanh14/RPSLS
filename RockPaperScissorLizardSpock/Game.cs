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
                if (choice != 1 && choice != 2 && choice != 3)
                {
                    Console.WriteLine("There are only 2 game modes!");
                    Console.WriteLine("Press enter to continue...");
                    return GetNumberOfPlayers();
                }
                else
                {
                    return choice;
                }               
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
            Random rand = new Random();
            if (numOfPlayers == 1)
            {
                playerOne = new Human();
                playerTwo = new Computer(rand);
            }
            else if (numOfPlayers == 2)
            {
                playerOne = new Human();
                playerTwo = new Human();
            }
            else if (numOfPlayers == 3)
            {
                playerOne = new Computer(rand);
                playerTwo = new Computer(rand);
            } 
            else
            {
            
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
            }
            else if (playerTwo.score == 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{playerTwo.name} wins {playerOne.score} - {playerTwo.score}");
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
                    CompareMoves();
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

        private void CompareMoves()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //Rock crushes scissors / Rock crushes lizard
            if (playerOne.gesture == playerTwo.gesture)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("TIE!?!");
            }
            else if (playerOne.gesture == "Rock" && (playerTwo.gesture == "Scissors" || playerTwo.gesture == "Lizard"))
            {
                Console.WriteLine($"{playerOne.gesture} beats {playerTwo.gesture}");
                playerOne.score++;

            }
            //Scissors cuts paper / Scissors decapitates lizard
            else if (playerOne.gesture == "Scissors" && (playerTwo.gesture == "Paper" || playerTwo.gesture == "Lizard"))
            {   
                Console.WriteLine($"{playerOne.gesture} beats {playerTwo.gesture}");
                playerOne.score++;
            }
            //Paper covers rock / Paper disproves spock
            else if (playerOne.gesture == "Paper" && (playerTwo.gesture == "Rock" || playerTwo.gesture == "Spock"))
            {
                Console.WriteLine($"{playerOne.gesture} beats {playerTwo.gesture}");
                playerOne.score++;
            }
            //Lizard poisons spock / Lizard eats paper
            else if (playerOne.gesture == "Lizard" && (playerTwo.gesture == "Spock" || playerTwo.gesture == "Paper"))
            {
                Console.WriteLine($"{playerOne.gesture} beats {playerTwo.gesture}");
                playerOne.score++;
            }
            //Spock smashes scissors / Spock vaporizes rock
            else if (playerOne.gesture == "Spock" && (playerTwo.gesture == "Scissors" || playerTwo.gesture == "Rock"))
            {
                Console.WriteLine($"{playerOne.gesture} beats {playerTwo.gesture}");
                playerOne.score++;
            }
           else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{playerTwo.gesture} beats {playerOne.gesture}");
                playerTwo.score++; 
            }
        }       
    }
}
