using Domine.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
    public class PlayerConfiguration: IEntityTypeConfiguration<Player>
    {

    public void Configure(EntityTypeBuilder<Player> builder)
    {
        builder.ToTable("Player");
        builder.Property(d => d.Dorsal)
        .IsRequired();
        builder.HasOne(t => t.Person)
        .WithOne(t => t.Player)
        .HasForeignKey<Person>(t => t.FKIdPlayer);
    }
}