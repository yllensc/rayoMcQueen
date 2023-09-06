using Domine.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
    public class PersonConfiguration: IEntityTypeConfiguration<Person>
    {

    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.ToTable("Person");
        builder.Property(n => n.FirstNamePerson)
        .IsRequired()
        .HasMaxLength(50);
        builder.Property(n => n.LastNamePerson)
        .IsRequired()
        .HasMaxLength(100);
        builder.Property(a => a.AgePerson)
        .IsRequired();
        builder.HasOne(t => t.Team)
        .WithMany(t => t.People)
        .HasForeignKey(t => t.FKIdTeam);

         builder.HasOne(t => t.PayRollType)
        .WithMany(t => t.People)
        .HasForeignKey(t => t.FKIdPayRollType);
        
        builder.HasOne(p => p.Player)
        .WithOne(P => P.Person)
        .HasForeignKey<Player>(p => p.FKIdPerson);
    }
}