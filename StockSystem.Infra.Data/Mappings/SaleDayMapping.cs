using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockSystem.Domain.Entities;

namespace StockSystem.Infra.Data.Mappings
{
    public class SaleDayMapping : IEntityTypeConfiguration<SaleDay>
    {
        public void Configure(EntityTypeBuilder<SaleDay> builder)
        {
            builder.ToTable("saleday");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .UseIdentityAlwaysColumn();

            builder.Property(x => x.DateDay)
                .HasColumnName("dateday");

            builder.Property(x => x.ResultDay)
                .HasColumnName("resultday");

            builder.Property(x => x.IdEstablishment)
                .HasColumnName("idestablishment");

            builder.HasOne(x => x.Establishment)
                .WithOne(x => x.SaleDay)
                .HasForeignKey<SaleDay>(x => x.IdEstablishment);
        }
    }
}
