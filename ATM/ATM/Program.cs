using System;

namespace ATM
{
    public class ATMApp
    {
        //establishes initial balance
        static public decimal balance = 300.00m;
        static void Main(string[] args)
        {
            UserInterface();
        }

        /// <summary>
        /// Runs menu and calls appropriate method based on user input
        /// </summary>
        static void UserInterface()
        {
            string menuInput = "";
            Console.WriteLine("Welcome Valued Customer!");
            //display menu as long as the user has not chosen the "Exit" option
            while(menuInput != "4")
            {
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1. Check balance.");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Exit");
                menuInput = Console.ReadLine();
                if(menuInput == "1")
                {
                    ViewBalance();
                }
                if(menuInput == "2")
                {
                    Console.Write("Amount to withdraw?: ");
                    string withdrawInput = Console.ReadLine();
                    decimal w = Convert.ToDecimal(withdrawInput);
                    Withdraw(w);
                    Console.WriteLine($"Your balance is now {balance}");
                    Console.WriteLine("Would you like to make another transaction?");
                }
                if(menuInput == "3")
                {
                    Console.Write("Amount to deposit?: ");
                    string depositInput = Console.ReadLine();
                    decimal d = Convert.ToDecimal(depositInput);
                    Deposit(d);
                    Console.WriteLine($"Your balance is now {balance}");
                    Console.WriteLine("Would you like to make another transaction?");
                }
                else if (menuInput != "1" && menuInput != "2" && menuInput != "3" && menuInput != "4")
                {
                    Console.WriteLine("Please choose a valid input.");
                }
            }
            Console.WriteLine("Thank you, please come again.");
        }

        /// <summary>
        /// Returns value of current balance
        /// </summary>
        /// <returns>decimal: balance</returns>
        public static decimal ViewBalance()
        {
            Console.WriteLine($"Your balance is: {balance}");
            return balance;
        }

        /// <summary>
        /// subtracts money from balance
        /// </summary>
        /// <param name="withdrawl"></param>
        /// <returns>decimal: updated balance</returns>
        public static decimal Withdraw(decimal withdrawl)
        {
            //check edge cases
            if(withdrawl < 0)
            {
                Console.WriteLine("Cannot withdraw a negative balance.");
            }
            else if(withdrawl > balance)
            {
                Console.WriteLine($"Cannot withdraw an amount greater than {balance}.");
            }
            else
            {
                balance-= withdrawl;
            }
            return balance;
        }

        /// <summary>
        /// adds money to balance
        /// </summary>
        /// <param name="deposit"></param>
        /// <returns>decimal: updated balance</returns>
        public static decimal Deposit(decimal deposit)
        {
            if(deposit < 0)
            {
                Console.WriteLine("Cannot deposit a negative amount");
            }
            else
            {
                balance += deposit;
            }
            return balance;
        }
    }
}
