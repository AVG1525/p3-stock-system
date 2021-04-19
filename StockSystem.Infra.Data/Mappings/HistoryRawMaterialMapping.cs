using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockSystem.Domain.Entities;

namespace StockSystem.Infra.Data.Mappings
{
    public class HistoryRawMaterialMapping : IEntityTypeConfiguration<HistoryRawMaterial>
    {
        public void Configure(EntityTypeBuilder<HistoryRawMaterial> builder)
        {
            builder.ToTable("historyrawmaterial");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .UseIdentityAlwaysColumn();

            builder.Property(x => x.DateDay)
                .HasColumnName("dateday");

            builder.Property(x => x.DateValidity)
                .HasColumnName("datevalidity");

            builder.Property(x => x.Amount)
                .HasColumnName("amount");

            builder.Property(x => x.UnitPrice)
                .HasColumnName("unitprice");

            builder.Property(x => x.IdRawMaterial)
                .HasColumnName("idrawmaterial");

            builder.HasOne(x => x.RawMaterial)
                .WithOne(x => x.HistoryRawMaterial)
                .HasForeignKey<HistoryRawMaterial>(x => x.IdRawMaterial);
        }
    }
}
