using Microsoft.Extensions.Options;
using Swyft.Core.Authentication;
using Swyft.Core.Data;
using Swyft.Core.Interfaces;
using Swyft.Core.Services;
using Swyft.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Swyft.UI
{
    public class UserInterface
    {
        private readonly IAuthView _authView;
        private readonly IAccountView _accountView;

        public UserInterface(IAuthView authView, IAccountView accountView )
        {
            _authView = authView;
            _accountView = accountView;
        }
    
        /// <summary>
        /// Start the application
        /// </summary>
        public void Run()
        {

            ForegroundColor = ConsoleColor.DarkYellow;

            // skip authentication and bank account creation stages
            Faker.Initiate();

            while (true)
            {
                while (Auth.CurrentUser == null)
                {
                    Print.PrintLogo();
                    _authView.DisplayAuthMenu();
                }

                _accountView.DisplayDashboard();
            }
        }
    }
}
