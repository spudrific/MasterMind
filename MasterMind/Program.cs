using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    class Program
    {
        static void Main(string[] args)
        {
            GamePlay.StartGame();
            var opponentCode = OpponentCode.GenerateRandomCode();
            var userCode = UserInput.GenerateUserCode();
            GamePlay.CompareCodes(opponentCode, userCode);    
        }
    }

    
}
