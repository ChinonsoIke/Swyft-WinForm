using Swyft.Core.Authentication;
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
        public static void Run()
        {
            Clear();

            bool running = true;

            while (running)
            {
                while (Auth.CurrentUser == null)
                {
                    AuthView.DisplayAuthMenu();
                }

                AccountView.DisplayAccountMenu();
            }
        }
    }
}
