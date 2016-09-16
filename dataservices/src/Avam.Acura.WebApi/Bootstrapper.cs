using System;
using Avam.Acura.DataServices.DB;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MySQL.Data.Entity.Extensions;

namespace Avam.Acura.Api
{
    public class Bootstrapper
    {
        public Bootstrapper (IHostingEnvironment env){
            var builder = new ConfigurationBuilder()
                            .SetBasePath(env.ContentRootPath)
                            .AddJsonFile("appSettings.json",optional : true, reloadOnChange:true)
                            .AddJsonFile("config.json");
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; set; }
        public void ConfigureServices(IServiceCollection services){
            Console.Write("Hi");
            var sqlConnectionString = Configuration["ConnectionStrings:AVAM"];
            services.AddDbContext<AvamCuraDBContext>(options=>{
                options.UseMySQL(sqlConnectionString);
            });
        }        
    }
}
