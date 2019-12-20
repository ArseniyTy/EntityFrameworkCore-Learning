using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EFCore_12_IntroModels.Many_to_many.Models;

namespace EFCore_12_IntroModels.Many_to_many
{
    class ThingContext : DbContext
    {
        public DbSet<Substance> Substances { get; set; }
        public DbSet<Element> Elements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS01;Database=MyHumanDataBase;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Element>()
                .HasKey(el => el.SerialNum);

            modelBuilder.Entity<SubstanceElement>()
                .HasKey(se => new { se.SubstanceId, se.ElementSerialNum });


            //Many-to-many through one-to-many
            modelBuilder.Entity<SubstanceElement>()
                .HasOne(se => se.Element)
                .WithMany(el => el.SubstanceElements)
                .HasForeignKey(se => se.ElementSerialNum);

        }
    }
}
