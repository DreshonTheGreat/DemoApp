using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.ApplicationInsights;

namespace ApplicationInsightsTutorial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateWebHostBuilder(
   string[] args) => Host.CreateDefaultBuilder(args)
      .ConfigureWebHostDefaults(webBuilder =>
      {
          webBuilder.UseStartup<Startup>();
      })
      .ConfigureLogging(logging =>
      {
          // clear default logging providers
          logging.ClearProviders();

          // add built-in providers manually, as needed 
          logging.AddConsole();
          logging.AddDebug();
          logging.AddEventLog();
          logging.AddEventSourceLogger();
      });

    }
}
