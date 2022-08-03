using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;
using Serilog.Formatting.Json;
using Swyft.Core.Interfaces;
using Swyft.Core.Services;
using Swyft.Forms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swyft
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CultureInfo.CurrentCulture = new CultureInfo("en-NG", false);

            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddScoped<IUserService, UserService>();
                    services.AddScoped<ITransactionService, TransactionService>();
                    services.AddScoped<IAccountService, AccountService>();
                    services.AddSingleton<Form1>();
                    services.AddTransient<Login>();
                    services.AddTransient<Register>();
                    services.AddTransient<Dashboard>();
                    services.AddTransient<Home>();
                    services.AddTransient<Statement>();
                    services.AddTransient<Transfer>();
                    services.AddTransient<Withdrawal>();
                    services.AddTransient<Deposit>();
                    services.AddTransient<CreateBankAccount>();
                })
                .UseSerilog()
                .Build();

            Log.Logger = new LoggerConfiguration()
                .WriteTo.File(new JsonFormatter(), Path.Combine(Environment.CurrentDirectory, "logs", "swyft-important.json"), restrictedToMinimumLevel: LogEventLevel.Warning)
                .WriteTo.File(Path.Combine(Environment.CurrentDirectory, "logs", "swyft-.logs"), rollingInterval: RollingInterval.Day)
                .WriteTo.Debug()
                .MinimumLevel.Debug()
                .CreateLogger();

            Application.Run(host.Services.GetRequiredService<Form1>());
        }
    }
}
