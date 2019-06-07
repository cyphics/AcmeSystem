using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using AcmeSystem.Business.Contacts;
using AcmeSystem.Business.Clients;

namespace AcmeSystem.Persistence.EntityRepositories
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            AcmeSystemDbContext context = app.ApplicationServices
            .GetRequiredService<AcmeSystemDbContext>();
            context.Database.Migrate();
            if (!context.Contacts.Any())
            {
                context.Contacts.AddRange(
                    ContactFactory.GetFakeContacts()
                    );

                context.SaveChanges();
            }

            if (!context.Clients.Any())
            {
                context.Clients.AddRange(
                    ClientFactory.GetFakeClients()
                    );

                context.SaveChanges();
            }
        }
    }
}
