using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EFCore_12_IntroModels.One_to_one.Models;

namespace EFCore_12_IntroModels.One_to_one
{
    class NewYearContext : DbContext
    {
        public DbSet<Present> Presents { get; set; }
        public DbSet<Box> Boxes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS01;Database=MyHumanDataBase;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
