﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using CurriculumPlanning.Shared.Data;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;

namespace CurriculumPlanning.WebApp
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();

            //services.AddMvc()
            //    .AddJsonOptions(options =>
            //    {
            //        options.SerializerSettings.ReferenceLoopHandling = 
            //            Newtonsoft.Json.ReferenceLoopHandling.Ignore;

            //        //var resolver = options.SerializerSettings.ContractResolver;
            //        //if (resolver != null)
            //        //{
            //        //    var res = resolver as DefaultContractResolver;
            //        //    res.NamingStrategy = null;
            //        //}
            //    });

            // Add the EF database context.
            // TODO Move the database connection string to a configuration file.
            var connection = @"Server=(localdb)\mssqllocaldb;Database=CurriculumPlanning;Trusted_Connection=True;";
            services.AddDbContext<Context>(options => options.UseSqlServer(connection));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, 
            ILoggerFactory loggerFactory, IServiceScopeFactory serviceScopeFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                // Browser Link is not compatible with Kestrel 1.1.0
                // For details on enabling Browser Link, see https://go.microsoft.com/fwlink/?linkid=840936
                // app.UseBrowserLink();

                using (var scope = serviceScopeFactory.CreateScope())
                {
                    var context = scope.ServiceProvider.GetService<Context>();
                    context.Database.Migrate();
                    context.EnsureSeedData();
                }
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.Use(async (context, next) => {
                // TODO Add other client-side routes.
                if (context.Request.Path == "/courses" || 
                    context.Request.Path == "/skills" ||
                    context.Request.Path == "/teachers" ||
                    context.Request.Path == "/topics")
                {
                    context.Request.Path = "/index.html";
                }
                await next.Invoke();
            });

            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
