using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace Demo.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseKestrel()
                .UseIISIntegration()
                .UseStartup("Demo.Bootstrapper")
                .Build();

            host.Run();
        }
    }
}