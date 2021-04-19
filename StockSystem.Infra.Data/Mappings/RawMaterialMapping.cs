using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockSystem.Domain.Entities;

namespace StockSystem.Infra.Data.Mappings
{
    public class RawMaterialMapping : IEntityTypeConfiguration<RawMaterial>
    {
        public void Configure(EntityTypeBuilder<RawMaterial> builder)
        {
            builder.ToTable("rawmaterial");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .UseIdentityAlwaysColumn();

            builder.Property(x => x.IdDescriptionRawMaterial)
                .HasColumnName("iddescriptionrawmaterial");

            builder.Property(x => x.IdEstablishment)
                .HasColumnName("idestablishment");

            builder.HasOne(x => x.DescriptionRawMaterial)
                .WithOne(x => x.RawMaterial)
                .HasForeignKey<RawMaterial>(x => x.IdDescriptionRawMaterial);

            builder.HasOne(x => x.Establishment)
                .WithOne(x => x.RawMaterial)
                .HasForeignKey<RawMaterial>(x => x.IdEstablishment);
        }
    }
}
