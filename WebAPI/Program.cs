using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.DependencyResolvers.Autofac;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Core;
using Microsoft.Extensions.DependencyInjection;
using Serilog.Extensions.Logging.File;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
{
    public class Program
    {


        public static void Main(string[] args)
        {
            IConfigurationRoot config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            Log.Logger= new LoggerConfiguration()
           .ReadFrom.Configuration(config)
           .CreateLogger();
            try
            {
                Log.Information("Application Starting.");
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "The Application failed to start.");
            }
            finally
            {
                Log.CloseAndFlush();
            } 
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .UseSerilog()
            .UseServiceProviderFactory(new AutofacServiceProviderFactory())

            .ConfigureContainer<ContainerBuilder>(
                builder => { builder.RegisterModule(new AutofacBusinessModule()); }
                )
                .ConfigureWebHostDefaults(webBuilder =>
                {

                    webBuilder.UseStartup<Startup>();
                });
    }
}
