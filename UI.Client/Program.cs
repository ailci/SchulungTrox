using Application.Contracts;
using Application.ViewModels;
using Data;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using UI.Client.Services;
using Util;


var host = Host.CreateDefaultBuilder(args)
    .ConfigureHostConfiguration(opt =>
    {
        opt.SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
    })
    .ConfigureServices((context, services) =>
    {
        //ConnectionString
        var connectionString = context.Configuration.GetConnectionString("DefaultConnection") ??
                               throw new InvalidOperationException("Kein Connection gefunden..");

        services.AddDbContext<QotdDbContext>(options =>
        {
            //Sql Server
            //options.UseSqlServer(connectionString);

            //Sqlite
            options.UseSqlite("Data Source=projektqotd.db");
        });

        //DependencyInject
        services.AddScoped<IQotdService, QotdService>();
        services.AddKeyedScoped<IQotdService, QotdApiService>("qotdapi");
    })
    .Build();

//#######################################################################################

ColorConsole.WriteWrappedHeader("Qotd-APP");

ShowQuoteOfTheDay();

void ShowQuoteOfTheDay()
{
    //var qotdDbContext = host.Services.GetRequiredService<QotdDbContext>(); //Butler der den Kühlschrank öffnet und eine Instanz von DbContext holt
    var qotdService = host.Services.GetRequiredService<IQotdService>();
    var qotdApiService = host.Services.GetRequiredKeyedService<IQotdService>("qotdapi");

    var qotdVm = qotdService.GetQuoteOfTheDayViewModel();

    ColorConsole.WriteLine("\nSpruch Des Tages\n", ConsoleColor.Green);
    ColorConsole.WriteLine($"\"{qotdVm.QuoteText}\"", ConsoleColor.Yellow);
    ColorConsole.WriteLine($"{qotdVm.AuthorName} ## {qotdVm.AuthorDescription} ## {qotdVm.AuthorBirthDate?.ToShortDateString() ?? ""}", ConsoleColor.Cyan);
}

