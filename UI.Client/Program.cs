using Data;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
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
    })
    .Build();


ColorConsole.WriteWrappedHeader("Qotd-APP");
