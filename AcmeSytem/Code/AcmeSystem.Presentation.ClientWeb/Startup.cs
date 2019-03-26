﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcmeSystem.Applicative.Services;
using AcmeSystem.Business;
using AcmeSystem.Persistence.MockRepositories;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using AcmeSystem.Persistence.EntityRepositories;
using Microsoft.AspNetCore.Identity;
using AcmeSystem.Presentation.ClientWeb.Infrastructure;

namespace AcmeSystem.Presentation.ClientWeb
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AcmeSystemDbContext>(options => options.UseSqlServer(
                Configuration["Data:AcmeSystemEntityDb:ConnectionString"]));

            services.AddDbContext<AppIdentityDbContext>(options => options.UseSqlServer(
                Configuration["Data:AcmeSystemIdentity:ConnectionString"]));

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppIdentityDbContext>()
                .AddDefaultTokenProviders();

            //* Commandes à utiliser pour creer la migration d'Identity Database :
            //* dotnet ef migrations add Initial --context AppIdentityDbContext
            //* dotnet ef database update --context AppIdentityDbContext

            //services.AddTransient<IContactRepository, ContactRepositoryMock>();
            services.AddTransient<IContactRepository, EFContactRepository>();

            services.AddTransient<IContactServices, ContactServices>();

            services.AddMemoryCache();
            services.AddSession();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();

            app.UseStaticFiles();

            app.UseSession();
            app.UseAuthentication();

            app.UseMvc(routes =>
            { 
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "pagination",
                    template: "Contact/Page{contactPage}",
                    defaults: new { Controller = "Contact", action = "List" });

                routes.MapRoute(
                    name: "contacts",
                    template: "{controller=Contact}/{action=List}/{id?}");
            });

            SeedData.EnsurePopulated(app);
            IdentitySeedData.EnsurePopulated(app);
        }
    }
}
