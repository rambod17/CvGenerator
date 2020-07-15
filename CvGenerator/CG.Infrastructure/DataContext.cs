using CG.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace CG.Infrastructure
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured || string.IsNullOrEmpty(Environment.GetEnvironmentVariable("CONNECTION_STRING")))
            {
                optionsBuilder.UseInMemoryDatabase(databaseName: "CvGenerator");
            }
        }

        // Entities
        public DbSet<User> ApplicationUsers { get; set; }
    }
}
