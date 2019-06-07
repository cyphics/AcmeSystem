﻿// <auto-generated />
using System;
using AcmeSystem.Persistence.EntityRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AcmeSystem.Persistence.EntityRepositories.Migrations
{
    [DbContext(typeof(AcmeSystemDbContext))]
    partial class AcmeSystemDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AcmeSystem.Business.Contacts.Adresse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Localite");

                    b.Property<string>("Npa");

                    b.Property<string>("Numero");

                    b.Property<string>("Rue");

                    b.HasKey("Id");

                    b.ToTable("Adresses");
                });

            modelBuilder.Entity("AcmeSystem.Business.Contacts.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdresseId");

                    b.Property<string>("Nom");

                    b.Property<string>("Prenom");

                    b.HasKey("Id");

                    b.HasIndex("AdresseId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("AcmeSystem.Business.Contacts.Contact", b =>
                {
                    b.HasOne("AcmeSystem.Business.Contacts.Adresse", "Adresse")
                        .WithMany()
                        .HasForeignKey("AdresseId");
                });
#pragma warning restore 612, 618
        }
    }
}
