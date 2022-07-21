using Figgle;
using Swyft.Models;
using Swyft.Utility;
using System;
using System.Collections.Generic;
using System.Threading;
using static System.Console;

namespace Swyft.Helpers
{
    public class Print
    {
        /// <summary>
        /// Print a list of bank accounts to the console.
        /// </summary>
        /// <param name="accounts"></param>
        public static void PrintAccountDetails(List<Account> accounts)
        {
            Console.WriteLine($"| {"---",-3} | {"---------------------------",-27} | {"-------------",-14} | {"------------",-12} | {"-------------------",-19} |");
            Console.WriteLine($"| {"S/N",-3} | {"ACCOUNT NAME",-27} | {"ACCOUNT NUMBER",-13} | {"ACCOUNT TYPE",-12} | {"ACCOUNT BALANCE",-19} |");
            Console.WriteLine($"| {"---",-3} | {"---------------------------",-27} | {"--------------",-14} | {"------------",-12} | {"-------------------",-19} |");
            int num = 0;

            foreach (var account in accounts)
            {
                Thread.Sleep(300);
                Console.WriteLine($"| {++num,-3} | {account.AccountName,-27} | {account.AccountNumber,-14} | {account.Type,-12} | {account.Balance,19:C} |");
            }
            Console.WriteLine($"| {"---------------------------------------------------------------------------------------",-87} |");
        }

        /// <summary>
        /// Print a statement containing a list of previous transactions on an account
        /// </summary>
        /// <param name="account"></param>
        /// <param name="transactions"></param>
        public static void PrintAccountStatement(Account account, List<Transaction> transactions)
        {
            Console.WriteLine($"ACCOUNT STATEMENT FOR [ {account.AccountName}, {account.AccountNumber} ]");

            Console.WriteLine($"| {"----------",-10} | {"----------------------------------",-34} | {"-------------------",-19} | {"----------",-10} | {"-------------------",-19} |");
            Console.WriteLine($"| {"DATE",-10} | {"DESCRIPTION",-34} | {"AMOUNT",-19} | {"TYPE",-10} | {"BALANCE",-19} |");
            Console.WriteLine($"| {"----------",-10} | {"----------------------------------",-34} | {"-------------------",-19} | {"----------",-10} | {"-------------------",-19} |");

            if(transactions.Count > 0)
            {
                foreach (var transaction in transactions)
                {
                    Thread.Sleep(300);
                    Write($"| {transaction.CreatedAt.ToString("d"),-10} ");
                    Write($"| {transaction.Description,-34} | ");
                    BackgroundColor = transaction.Type == TransType.Debit ? ConsoleColor.DarkRed : ConsoleColor.DarkGreen;
                    Write($"{transaction.Amount,19:C}");
                    BackgroundColor = ConsoleColor.Black;
                    Write($" | {transaction.Type,-10} ");
                    WriteLine($"| {transaction.AccountBalance,19:C} |");
                }
            }
            Console.WriteLine($"| {"--------------------------------------------------------------------------------------------------------",-90} |");
        }

        /// <summary>
        /// Print Swyft logo to console
        /// </summary>
        public static void PrintLogo()
        {
            Clear();
            BackgroundColor = ConsoleColor.DarkBlue;
            ForegroundColor = ConsoleColor.Black;
            WriteLine(FiggleFonts.Slant.Render("            Swyft Bank >>>           "));
            ForegroundColor = ConsoleColor.DarkBlue;
            BackgroundColor = ConsoleColor.Black;
        }

        public static string GetGreeting()
        {
            var now = DateTime.Now;

            if (now.Hour > 16) return "evening";
            else if (now.Hour >= 12) return "afternoon";
            else return "morning";
        }
    }
}
