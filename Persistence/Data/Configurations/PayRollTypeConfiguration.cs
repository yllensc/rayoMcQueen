using Domine.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Persistence.Data.Configurations;
    public class PayRollTypeConfiguration: IEntityTypeConfiguration<PayRollType>
    {

    public void Configure(EntityTypeBuilder<PayRollType> builder)
    {
        builder.ToTable("PayRollType");
        builder.Property(n => n.NameType)
        .IsRequired();
        builder.HasIndex(n => n.NameType)
        .IsUnique();
    }
}