using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;


namespace Avam.Acura.Api
{
    public class Bootstrapper
    {
        public void Configure(IApplicationBuilder  appBuilder){
            appBuilder.Run(context =>{
                return context.Response.WriteAsync("Hello   from ASP.NET Core!");
            });
        }
    }
}
