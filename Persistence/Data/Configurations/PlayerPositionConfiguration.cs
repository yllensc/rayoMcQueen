using Domine.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class PlayerPositionConfiguration : IEntityTypeConfiguration<PlayerPosition>
{

    public void Configure(EntityTypeBuilder<PlayerPosition> builder)
    {
        builder.ToTable("PlayerPosition");
        builder.HasKey(pp => new { pp.FKIdPlayer, pp.FKIdPosition }); // Definir clave primaria compuesta

        builder.HasOne(pp => pp.Player)
            .WithMany()
            .HasForeignKey(pp => pp.FKIdPlayer);

        builder.HasOne(pp => pp.Position)
            .WithMany()
            .HasForeignKey(pp => pp.FKIdPosition);
    }
}