using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rspOOP
{
    public class BOT
    {
        public string GetChoice()
        {
            //Computer chooses  a random choice
            Random random = new Random();
            //int computerChoice = random.Next(1,4);
            string[] choices = { "Rock", "Paper", "Scissors" };
            //convert
            string computerChoice = choices[random.Next(1, 4) - 1];
            return computerChoice;
        }

    }

}