using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using MongoDB.Driver;

namespace Catalogo.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var mongoClient = new MongoClient("mongodb://mongo:27017");
            var mongoDatabase = mongoClient.GetDatabase("LogsDB");

            Log.Logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .WriteTo.MongoDB(
                    mongoDatabase,
                    collectionName: "CatalogLogs",
                    period: TimeSpan.FromSeconds(1))
                .CreateLogger();

            try
            {
                Log.Information("Starting up Catalogo.API");
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Application start-up failed");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
