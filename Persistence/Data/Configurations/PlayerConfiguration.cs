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
        .WithMany(t => t.Players)
        .HasForeignKey(t => t.FKIdPerson);
    }
}