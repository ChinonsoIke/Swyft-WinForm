using Swyft.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swyft.UI
{
    public interface IAuthView
    {
        /// <summary>
        /// Display the authentication menu
        /// </summary>
        public void DisplayAuthMenu();
        
        /// <summary>
        /// Display login form to user
        /// </summary>
        public void Login();
        
        /// <summary>
        /// Display register form to user
        /// </summary>
        public void Register();
    }
}
