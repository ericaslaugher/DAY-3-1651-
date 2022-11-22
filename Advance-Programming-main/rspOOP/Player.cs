using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rspOOP
{
    public class Player
    {
        private int balance;
        public int Balance
        {
            get { return balance; }     // Write (piBalance)
            // set { balance = value; }  // // Error if piBalance = 10 (Do khong tim thay ham set)
        }
        //Player
        public Player()
        {
            balance = 10;
        }
        public string GetChoice()
        {
            string userChoice = "";
            bool validChoice = false;
            while (!validChoice)
            {
                Console.Write("Choose Rock, Paper, or Scissors: ");
                userChoice = Console.ReadLine();
                validChoice = userChoice == "Rock" || userChoice == "Paper" || userChoice == "Scissors";
                if (!validChoice)
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
            return userChoice;
        }
        //IsPlayAgain
        public bool IsPlayAgain()
        {
            System.Console.WriteLine("Do you want to play again? (y/n): ");
            string playAgain = Console.ReadLine();
            bool playing = playAgain == "y";

            return playing;
        }
        //Deposit
        public void Deposit(int amount)
        {
            if (amount <= 0)
                System.Console.WriteLine("Invalid amount. Please try again.");
            else
                balance += amount;

        }
        //Update the balance
        public void UpdateBalance(int amount)
        {
            balance += amount;
        }
    }
}