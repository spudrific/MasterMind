using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    public class UserInput
    {
        public static int GenerateUserCode()
        {
            int userOutput = TakeUserInput();
            Console.WriteLine("Your code: " + userOutput);
            return userOutput;
        }

        public static int TakeUserInput()
        {
            string userInput = Console.ReadLine();
            int num = 0;

            while (NumberCheck(userInput, out num))
            {
                Console.WriteLine("Your code is invalid. Please enter only four numbers between 1 and 6. \nTry Again:");
                userInput = Console.ReadLine();
            }

            return num;
        }

        public static bool NumberCheck(string userInput, out int num)
        {
            return !int.TryParse(userInput, out num) || userInput.Contains("0") || userInput.Contains("7") || userInput.Contains("8") || userInput.Contains("9") || userInput.Length != 4;
        }
    }
}
