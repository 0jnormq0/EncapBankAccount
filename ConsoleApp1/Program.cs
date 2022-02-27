using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var transaction = new BankAccount();
            var depositAmt = 0.0;
            var yesNo = "";
            var check = true;
            var currentBalance = 0.0;
            transaction.GetBalance(currentBalance);

            askBalance(check);
            askDeposit(check);
            askBalance(check);
            askDeposit(check);
            askBalance(check);

            //Method to ask whether user wants to check balance
            void askBalance(bool yes)
            {
                Console.WriteLine("Do you want to check your balance (Y/N)?");
                yesNo = Console.ReadLine().ToLower();
                CheckBalance(yesNo);
            }

            //Method to ask whether user wants to make a deposit
            void askDeposit(bool yes)
            {
                Console.WriteLine("Do you want to make a deposit (Y/N)?");
                yesNo = Console.ReadLine().ToLower();
                DepositMoney(yesNo);
            }

            //Method to ask user to deposit money
            void DepositMoney(string userSelect)
            {
                if (yesNo == "")
                {
                    Console.WriteLine("Please enter a 'Y' or 'N' if you want to make a deposit.");
                    yesNo = Console.ReadLine().ToLower();
                    if (yesNo == "y")
                    {
                        Console.WriteLine("Please enter an amount to deposit:");
                        double.TryParse(Console.ReadLine(), out depositAmt);

                        //Add deposit amount to current balance
                        currentBalance = transaction.GetBalance(transaction.Deposit(depositAmt));
                    }
                    else if (yesNo == "n")
                    {
                        Console.WriteLine("Thank you for banking with us!");
                    }
                    else
                    {
                        Console.WriteLine("Thank you for banking with us!");
                    }
                }
                else if (yesNo == "y")
                {
                    Console.WriteLine("Please enter an amount to deposit:");
                    double.TryParse(Console.ReadLine(), out depositAmt);
                    //Add deposit amount to current balance
                    currentBalance = transaction.GetBalance(transaction.Deposit(depositAmt));
                }
                else if (yesNo == "n")
                {
                    Console.WriteLine("Thank you for banking with us!");
                }
                else
                {
                    Console.WriteLine("Thank you for banking with us!");
                }

            }          

            //Method to determine whether user wants to check balance
            void CheckBalance(string userSelect)
            {
                if (yesNo == "")
                {
                    Console.WriteLine("Please enter a 'Y' or 'N' if you want to check your balance.");
                    yesNo = Console.ReadLine().ToLower();
                    if (yesNo == "y")
                    {
                        transaction.GetBalance(currentBalance);
                        Console.WriteLine($"Your balance is: {currentBalance}");
                    }
                    else if (yesNo == "n")
                    {
                        Console.WriteLine("Thank you for banking with us!");
                    }
                    else
                    {
                        Console.WriteLine("Thank you for banking with us!");
                    }
                }
                else if (yesNo == "y")
                {
                    transaction.GetBalance(currentBalance);
                    Console.WriteLine($"Your balance is: {currentBalance}");
                }
                else if (yesNo == "n")
                {
                    Console.WriteLine("Thank you for banking with us!");
                }
                else
                {
                    Console.WriteLine("Thank you for banking with us!");
                }
            }
        
        }
    }
}
