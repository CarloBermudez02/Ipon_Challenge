using System;

namespace IponChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Ipon Challenge!");

            int dailyDeposit = 0;
            int totalSavings = 0;
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nChoose your action:");
                Console.WriteLine("1. Set Daily Deposit");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Calculate Total Savings");
                Console.WriteLine("4. Check Balance");
                Console.WriteLine("5. Exit");
                Console.Write("\nEnter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter your daily deposit amount: ");
                        dailyDeposit = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Daily deposit set to: " + dailyDeposit);
                        break;
                    case 2:
                        Console.Write("Enter the amount to deposit: ");
                        int depositAmount = Convert.ToInt32(Console.ReadLine());
                        totalSavings += depositAmount;
                        Console.WriteLine("Successfully deposited: " + depositAmount);
                        break;
                    case 3:
                        if (dailyDeposit > 0)
                        {
                            totalSavings = dailyDeposit * 365;
                            Console.WriteLine("Total savings: " + totalSavings);
                        }
                        else
                        {
                            Console.WriteLine("Please set your daily deposit amount first.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Current balance: " + totalSavings);
                        break;
                    case 5:
                        exit = true;
                        Console.WriteLine("\nThank you for using our service!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}

