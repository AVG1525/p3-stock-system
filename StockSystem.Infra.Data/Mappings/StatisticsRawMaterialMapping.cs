using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockSystem.Domain.Entities;

namespace StockSystem.Infra.Data.Mappings
{
    public class StatisticsRawMaterialMapping : IEntityTypeConfiguration<StatisticsRawMaterial>
    {
        public void Configure(EntityTypeBuilder<StatisticsRawMaterial> builder)
        {
            builder.ToTable("statisticsrawmaterial");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .UseIdentityAlwaysColumn();

            builder.Property(x => x.DateDay)
                .HasColumnName("dateday");

            builder.Property(x => x.EstimatedStockDateEmpty)
                .HasColumnName("estimatedstockdateempty");

            builder.Property(x => x.IdRawMaterial)
                .HasColumnName("idrawmaterial");

            builder.HasOne(x => x.RawMaterial)
                .WithOne(x => x.StatisticsRawMaterial)
                .HasForeignKey<StatisticsRawMaterial>(x => x.IdRawMaterial);
        }
    }
}
