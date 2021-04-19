using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockSystem.Domain.Entities;

namespace StockSystem.Infra.Data.Mappings
{
    public class EstablishmentMapping : IEntityTypeConfiguration<Establishment>
    {
        public void Configure(EntityTypeBuilder<Establishment> builder)
        {
            builder.ToTable("establishment");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .UseIdentityAlwaysColumn();

            builder.Property(x => x.Name)
                .HasColumnName("name");

            builder.Property(x => x.IdUser)
                .HasColumnName("iduser");

            builder.HasOne(x => x.User)
                .WithOne(x => x.Establishment)
                .HasForeignKey<Establishment>(x => x.IdUser);
        }
    }
}
