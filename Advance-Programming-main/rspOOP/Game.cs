using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rspOOP
{
    public class Game
    {
        private const int REWARD = 5;
        private Player player;
        private BOT bot;
        public Game()
        {
            player = new Player();
            bot = new BOT();
        }
        //
        public string CompareResult(string userChoice, string computerChoice)
        {

            if (userChoice == computerChoice)
            {
                return "Tie";
            }
            else if
                ((userChoice == "Rock" && computerChoice == "Scissors") ||
                (userChoice == "Paper" && computerChoice == "Rock") ||
                (userChoice == "Scissors" && computerChoice == "Paper"))
            {
                return "Win";
            }
            else
            {
                return "Lose";
            }
        }
        //Update the player
        public void UpdatePlayerBalance(string result)
        {
            if (result == "Win") player.UpdateBalance(REWARD);
            else if (result == "Lose") player.UpdateBalance(-REWARD);
        }
        //Print Game
        public void PrintGameStatus(string result)
        {
            Console.WriteLine("Game result: " + result);
            Console.WriteLine("Your current balance: $" + player.Balance);
        }
        //Print final status
        public void PrintFinalStatus()
        {
            Console.WriteLine("YOur final balance: " + player.Balance);
            Console.WriteLine("Thanks for playing !!");
        }
        // Play
        public void Play()
        {
            player.Deposit(50);
            bool playing = true;
            while (playing)
            {
                string computerChoice = bot.GetChoice();
                string userChoice = player.GetChoice();  //????

                string result = CompareResult(userChoice, computerChoice);
                UpdatePlayerBalance(result);
                PrintGameStatus(result);

                playing = player.Balance >= REWARD && player.IsPlayAgain();

            }
            PrintFinalStatus();
        }
    }
}