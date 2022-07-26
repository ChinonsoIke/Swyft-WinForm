using Microsoft.Extensions.DependencyInjection;
using Swyft.Core.Authentication;
using Swyft.Helpers;
using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace Swyft.UI
{
    public class UserInterface
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IAccountView _accountView;

        public UserInterface(IServiceProvider serviceProvider, IAccountView accountView )
        {
            _serviceProvider = serviceProvider;
            _accountView = accountView;
        }
    
        /// <summary>
        /// Start the application
        /// </summary>
        public async Task Run()
        {
            await FileOperations.LoadDatabase();
            Console.WriteLine(FileOperations.usersFile);

            // set console output encoding to accept unicode
            OutputEncoding = System.Text.Encoding.UTF8;

            // change current culture to english-Nigeria
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-NG", false);

            //Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencySymbol = "\u20A6"; // set currency symbol to naira (already works)

            ForegroundColor = ConsoleColor.DarkBlue;

            // skip authentication and bank account creation stages
            Faker.Initiate();

            while (true)
            {
                while (Auth.CurrentUser == null)
                {
                    Print.PrintLogo();
                    var _authView = _serviceProvider.GetRequiredService<AuthView>();
                    _authView.DisplayAuthMenu();
                }

                _accountView.DisplayDashboard();
            }
        }
    }
}
