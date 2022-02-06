using CleanArchitectureTemplate.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitectureTemplate.Persistence.EntityTypeConfigurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {

            builder.HasKey(x => x.Id);

            builder.Property(x => x.FirstName)
                .HasColumnName("First_name")
                .HasMaxLength(100);

            builder.Property(x => x.LastName)
                .HasColumnName("Last_name")
                .HasMaxLength(200);

            builder.Property(x => x.Email);

        }
    }
}
