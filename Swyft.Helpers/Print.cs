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
        public static string GetGreeting()
        {
            var now = DateTime.Now;

            if (now.Hour > 16) return "evening";
            else if (now.Hour >= 12) return "afternoon";
            else return "morning";
        }
    }
}
