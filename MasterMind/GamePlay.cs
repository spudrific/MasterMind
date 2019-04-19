using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    public class GamePlay
    {
        public static int guesses = 10;

        public static void ContinueGame(int opponentCode)
        {
           var userCode = UserInput.GenerateUserCode();
            CompareCodes(opponentCode, userCode);
        }

        public static void CompareCodes(int opponentCode, int userCode)
        {
            string opponentCodeStr = opponentCode.ToString();
            string userCodeStr = userCode.ToString();

            string[] sequence = new string[4]; 

            var opponentArray = opponentCodeStr.ToCharArray();
            var userArray = userCodeStr.ToCharArray();

            if (opponentArray.SequenceEqual(userArray)) {
                WinGame();
            }

            else
            {
                for (int ii = 0; ii < sequence.Length; ii++)
                {                    
                    if (opponentArray.Contains(userArray[ii]))
                    {
                        if (opponentArray[ii] == userArray[ii])
                        {
                            sequence[ii] = "+";
                        }

                        else
                        {
                            sequence[ii] = "-";
                        }
                    }
                }

                Console.WriteLine("Results: " + string.Join("", sequence));

                guesses--;
                Console.WriteLine("Keep guessing! You have {0} guess(es) left", guesses);

                if (guesses != 0)
                {
                    ContinueGame(opponentCode);
                }

                else
                {
                    GameOver(opponentCode);
                }
            }
        }

        public static void WinGame()
        {
            Console.WriteLine("Congratulations! You cracked the code!");
            ExitGame();
        }

        public static void GameOver(int opponentCode)
        {
            Console.WriteLine("The opponent's code was {0}. You have run out of guesses.", opponentCode);
            ExitGame();
        }

        public static void StartGame()
        {
            Console.WriteLine("Welcome to Mastermind! \nThe Master has generated an unbreakable 4-digit code! Can you figure it out? \nPlease enter 4 numbers between 1 and 6 to crack the code!");
        }

        public static void ExitGame()
        {
            Console.WriteLine("Press enter to exit the application.");
            string input = Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
