using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace AuthServer
{
    public class Program
    {
        private const string ApplicationEnvironmentVariablesPrefix = "AS_";
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
             .ConfigureAppConfiguration((_, builder) =>
                 builder.AddEnvironmentVariables(ApplicationEnvironmentVariablesPrefix))
            ;
    }
}