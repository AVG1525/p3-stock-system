using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockSystem.Domain.Entities;

namespace StockSystem.Infra.Data.Mappings
{
    public class StatisticsDayMapping : IEntityTypeConfiguration<StatisticsDay>
    {
        public void Configure(EntityTypeBuilder<StatisticsDay> builder)
        {
            builder.ToTable("statisticsday");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .UseIdentityAlwaysColumn();

            builder.Property(x => x.DateDay)
                .HasColumnName("dateday");

            builder.Property(x => x.RawMaterialExpenditure)
                .HasColumnName("rawmaterialexpenditure");

            builder.Property(x => x.GrowthRate)
                .HasColumnName("growthrate");

            builder.Property(x => x.IdEstablishment)
                .HasColumnName("idestablishment");

            builder.HasOne(x => x.Establishment)
                .WithOne(x => x.StatisticsDay)
                .HasForeignKey<StatisticsDay>(x => x.IdEstablishment);
        }
    }
}
