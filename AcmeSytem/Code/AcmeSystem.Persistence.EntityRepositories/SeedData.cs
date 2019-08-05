using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using AcmeSystem.Business.Contacts;
using AcmeSystem.Business.Comptes;

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
                    ContactFactory.CreateContact("Newton", "Isac", "Gravity street", "25", "1042", "London"),
                    ContactFactory.CreateContact("Holmes", "Sherlock", "Baker street", "121b", "1000", "London"),
                    ContactFactory.CreateContact("Babbage", "Charles", "Rue de la Science", "232", "1019", "Paris"),
                    ContactFactory.CreateContact("Lovelace", "Ada", "Rue de la programmation", "43", "1236", "Paris"),
                    ContactFactory.CreateContact("Pasteur", "Louis", "Rue du vaccin", "154", "1457", "Paris"),
                    ContactFactory.CreateContact("Turing", "Alan", "Rue du vaccin", "12", "1201", "London"),
                    ContactFactory.CreateContact("Maxwell", "James", "Magnetic Street", "47", "2589", "Edinbourg"),
                    ContactFactory.CreateContact("Tesla", "Nikola", "Electric Street", "547", "6021", "New York"),
                    ContactFactory.CreateContact("Edison", "Thomas", "Light Street", "584", "3010", "Boston"),
                    ContactFactory.CreateContact("Curie", "Marie", "Rue du Radium", "11", "1912", "Paris"),
                    ContactFactory.CreateContact("Faraday", "Michael", "Dynamo Street", "87", "1879", "London")
                    );

                context.SaveChanges();
            }

            if (!context.Comptes.Any())
            {
                context.Comptes.AddRange(
                    CompteFactory.CreateCompte("Google", "Gravity street", "25", "1042", "London"),
                    CompteFactory.CreateCompte("Facebook", "Gravity street", "25", "1042", "London"),
                    CompteFactory.CreateCompte("Amazon", "Gravity street", "25", "1042", "London"),
                    CompteFactory.CreateCompte("Microsoft", "Gravity street", "25", "1042", "London")
                                        );

                context.SaveChanges();
            }
        }


    }
}
