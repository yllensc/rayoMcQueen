using Domine.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
    public class PositionConfiguration: IEntityTypeConfiguration<Position>
    {

    public void Configure(EntityTypeBuilder<Position> builder)
    {
        builder.ToTable("Position");
        builder.Property(n => n.NamePosition)
        .IsRequired();
        builder.HasIndex(n => n.NamePosition)
        .IsUnique();
    }
}