using Domine.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {

    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.ToTable("Country");
        builder.Property(n => n.NameCountry)
        .IsRequired()
        .HasMaxLength(50);
        builder.HasIndex(n => n.NameCountry)
        .IsUnique();
    }
}