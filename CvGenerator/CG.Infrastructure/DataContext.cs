using CG.Domain.Entities;
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
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(AllCountries.GetCountries);
            base.OnModelCreating(builder);
        }
        // Entities
        public DbSet<Country> Countries { get; set; }
        public DbSet<Cv> Cvs { get; set; }
        public DbSet<CvOrigin> CvOrigins { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<PersonCv> PersonCvs { get; set; }
        public DbSet<CvSection> CvSections { get; set; }
        public DbSet<Input> Inputs{ get; set; }
        public DbSet<InputType> InputTypes { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<SectionType> SectionTypes { get; set; }
        public DbSet<SocialMedia> SocialMedias{ get; set; }
        public DbSet<SocialMediaCvSection> SocialMediaCvSections { get; set; }
    }
}
