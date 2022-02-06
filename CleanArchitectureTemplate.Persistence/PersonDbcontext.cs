using CleanArchitectureTemplate.Domain;
using CleanArchitectureTemplate.Persistence.EntityTypeConfigurations;
using Microsoft.EntityFrameworkCore;
using System;

namespace CleanArchitectureTemplate.Persistence
{
    public class PersonDbcontext : DbContext
    {
        public PersonDbcontext(DbContextOptions<PersonDbcontext> options) : base(options) { }
        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
