using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockSystem.Domain.Entities;

namespace StockSystem.Infra.Data.Mappings
{
    public class DescriptionRawMaterialMapping : IEntityTypeConfiguration<DescriptionRawMaterial>
    {
        public void Configure(EntityTypeBuilder<DescriptionRawMaterial> builder)
        {
            builder.ToTable("descriptionrawmaterial");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .UseIdentityAlwaysColumn();

            builder.Property(x => x.Description)
                .HasColumnName("description");
        }
    }
}
