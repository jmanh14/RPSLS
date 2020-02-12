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
        public int GetMove()
        {
            for (int i = 0; i < playerOne.gestures.Count; i++)
            {
                Console.WriteLine($"[{i + 1}]{playerOne.gestures[i].move}");
            }
            Console.WriteLine("Enter your move");
            Console.Write(">> ");
            int playerChoice = int.Parse(Console.ReadLine());
            return playerChoice;
        }
        public void PlayGame(int selection)
        {
           
            string humanMove;
            string computerMove;
            //Console.Clear();
            int choice;
            int choiceTwo;
            if (selection == 1)
            {
                playerTwo = new Computer();
                choice = GetMove();
                choiceTwo = 1;
            }
            else
            {
                GetName();
                playerTwo = new Human();
                choice = GetMove();
                choiceTwo = GetMove();
            }
            while (playerOne.score < 3 && playerTwo.score < 3)
            {               
                humanMove = playerOne.ChooseMove(choice);
                computerMove = playerTwo.ChooseMove(choiceTwo);
                CompareMoves(humanMove, computerMove);
                Console.WriteLine($"{playerOne.score} - {playerTwo.score}");
                
                Console.WriteLine("Press enter to continue...");
                Console.WriteLine();
            }
            if (playerOne.score == 3)
            {
                Console.WriteLine($"{playerOne.name} wins {playerOne.score} - {playerTwo.score}");
            }
            else if (playerTwo.score == 3)
            {
                Console.WriteLine($"{playerTwo.name} wins {playerOne.score} - {playerTwo.score}");
            }
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
                    playerTwo.score++;
                }
                
            }
            //Scissors cuts paper
            else if ((humanMove == "Scissors" && computerMove == "Paper") || (computerMove == "Scissors" && humanMove == "Paper"))
            {
                if(humanMove == "Scissors")
                {
                    Console.WriteLine($"{humanMove} cuts {computerMove}");
                    playerOne.score++;
                }
                else
                {
                    Console.WriteLine($"{computerMove} cuts {humanMove}");
                    playerTwo.score++;
                }
            }
            //Paper covers rock
            else if ((humanMove == "Paper" && computerMove == "Rock") || (computerMove == "Paper" && humanMove == "Rock"))
            {
                if (humanMove == "Paper")
                {
                    Console.WriteLine($"{humanMove} covers {computerMove}");
                    playerOne.score++;
                }
                else
                {
                    Console.WriteLine($"{computerMove} covers {humanMove}");
                    playerTwo.score++;
                }
            }
            //Rock crushes lizard
            else if ((humanMove == "Rock" && computerMove == "Lizard") || (computerMove == "Rock" && humanMove == "Lizard"))
            {
                if (humanMove == "Rock")
                {
                    Console.WriteLine($"{humanMove} crushes {computerMove}");
                    playerOne.score++;
                }
                else
                {
                    Console.WriteLine($"{computerMove} crushes {humanMove}");
                    playerTwo.score++;
                }
            }
            //Lizard poisons spock
            else if ((humanMove == "Lizard" && computerMove == "Spock") || (computerMove == "Lizard" && humanMove == "Spock"))
            {
                if (humanMove == "Lizard")
                {
                    Console.WriteLine($"{humanMove} poisons {computerMove}");
                    playerOne.score++;
                }
                else
                {
                    Console.WriteLine($"{computerMove} poisons {humanMove}");
                    playerTwo.score++;
                }
            }
            //Spock smashes scissors
            else if ((humanMove == "Spock" && computerMove == "Scissors") || (computerMove == "Spock" && humanMove == "Scissors"))
            {
                if (humanMove == "Spock")
                {
                    Console.WriteLine($"{humanMove} smashes {computerMove}");
                    playerOne.score++;
                }
                else
                {
                    Console.WriteLine($"{computerMove} smashes {humanMove}");
                    playerTwo.score++;
                }
            }
            //Scissors decapitates lizard
            else if ((humanMove == "Scissors" && computerMove == "Lizard") || (computerMove == "Scissors" && humanMove == "Lizard"))
            {
                if (humanMove == "Scissors")
                {
                    Console.WriteLine($"{humanMove} decapitates {computerMove}");
                    playerOne.score++;
                }
                else
                {
                    Console.WriteLine($"{computerMove} decapitates {humanMove}");
                    playerTwo.score++;
                }
            }
            //Lizard eats paper
            else if ((humanMove == "Lizard" && computerMove == "Paper") || (computerMove == "Lizard" && humanMove == "Paper"))
            {
                if (humanMove == "Lizard")
                {
                    Console.WriteLine($"{humanMove} eats {computerMove}");
                    playerOne.score++;
                }
                else
                {
                    Console.WriteLine($"{computerMove} eats {humanMove}");
                    playerTwo.score++;
                }
            }
            //Paper disproves Spock
            else if ((humanMove == "Paper" && computerMove == "Spock") || (computerMove == "Paper" && humanMove == "Spock"))
            {
                if (humanMove == "Paper")
                {
                    Console.WriteLine($"{humanMove} disproves {computerMove}");
                    playerOne.score++;
                }
                else
                {
                    Console.WriteLine($"{computerMove} disproves {humanMove}");
                    playerTwo.score++;
                }
            }
            //Spock vaporizes Rock
            else if ((humanMove == "Spock" && computerMove == "Rock") || (computerMove == "Spock" && humanMove == "Rock"))
            {
                if (humanMove == "Spock")
                {
                    Console.WriteLine($"{humanMove} vaporizes {computerMove}");
                    playerOne.score++;
                }
                else
                {
                    Console.WriteLine($"{computerMove} vaporizes {humanMove}");
                    playerTwo.score++;
                }
            }
           else
            {
                Console.WriteLine("TIE!?!");
            }
        }
    }
}
