using Domine.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
    public class TeamConfiguration: IEntityTypeConfiguration<Team>
    {

    public void Configure(EntityTypeBuilder<Team> builder)
    {
        builder.ToTable("Team");
        builder.Property(n => n.NameTeam)
        .IsRequired();
        builder.HasIndex(n => n.NameTeam)
        .IsUnique();
        builder.HasOne(t => t.Country)
        .WithMany(t => t.Teams)
        .HasForeignKey(t => t.FKIdCountry);

    }
}