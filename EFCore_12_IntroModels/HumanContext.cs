﻿using System;
using System.Collections.Generic;
using System.Text;
using EFCore_12_IntroModels.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore_12_IntroModels
{
    public class HumanContext : DbContext
    {
        public DbSet<Worker> Workers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS01;Database=MyHumanDataBase;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Worker>()
                                        .Property(w => w.Id)
                                        .HasColumnName("Worker ID");
            modelBuilder.Entity<Worker>()
                                        .Property(w => w.Age).HasDefaultValue(18);
            modelBuilder.Entity<Worker>()
                                        .Property(w => w.Name).IsRequired();
        }
    }
}