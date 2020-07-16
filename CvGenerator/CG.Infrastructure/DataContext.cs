﻿using CG.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace CG.Infrastructure
{
    public class DataContext : IdentityDbContext<ApplicationUser>
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured || string.IsNullOrEmpty(Environment.GetEnvironmentVariable("CONNECTION_STRING")))
            {
                //optionsBuilder.UseInMemoryDatabase(databaseName: "CvGenerator");
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=aspnet-CvGenerator-4ae3798a;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        // Entities
    }
}
