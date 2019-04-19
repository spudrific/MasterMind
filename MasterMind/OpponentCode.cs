using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    public class OpponentCode
    {

        public static int GenerateRandomCode()
        {
            int code = 0;
            Random random = new Random();

            for (int i = 0; i < 4; i++)
            {
                int digit = random.Next(1, 7);
                code = 10 * code + digit;

            }
            //Console.WriteLine(code);
            Console.WriteLine(code.GetType());
            return code;
        }

    }
}
