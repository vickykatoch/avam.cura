using System;
using Microsoft.AspNetCore.Hosting;

namespace Avam.Acura.Api
{
    public class Program
    {
        public static void Main(string[] args) {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Bootstrapper>()
                .Build();

            host.Run();
        }
    }
}
