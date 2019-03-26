using AcmeSystem.Business.Contacts;
using Microsoft.EntityFrameworkCore;
using System;

namespace AcmeSystem.Persistence.EntityRepositories
{
    public class AcmeSystemDbContext : DbContext
    {
        public AcmeSystemDbContext(DbContextOptions<AcmeSystemDbContext> options)
            :base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Adresse> Adresses{ get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionStr = "Server=(localdb)\\MSSQLLocalDB;Database=AcmeSystem;Trusted_Connection=True;MultipleActiveResultSets=true";
                optionsBuilder.UseSqlServer(connectionStr);
            }
        }


    }
}
