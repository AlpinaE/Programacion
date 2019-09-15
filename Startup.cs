﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using programcion.models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<DatabaseContext>(options =>
                  
                    options.UseNpgsql(
            "Host=ec2-54-83-9-36.compute-1.amazonaws.com;" +
            "Database=d8fu2pme4iblpe;Username=fmyjodzhnsgdjz;"+
            "Password=f2fe8b1e9a171db0c8706a223fa5dcb2217f5e6771d2b3ce5b761d83a5228fa7;"+
            "Port=5432;SSL Mode=Require;Trust Server Certificate=true")
                  ); 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles(); // For the wwwroot folder
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            /* app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });*/

            app.UseMvc(routes => {

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
