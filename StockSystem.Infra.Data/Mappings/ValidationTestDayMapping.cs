using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockSystem.Domain.Entities;

namespace StockSystem.Infra.Data.Mappings
{
    public class ValidationTestDayMapping : IEntityTypeConfiguration<ValidationTestDay>
    {
        public void Configure(EntityTypeBuilder<ValidationTestDay> builder)
        {
            builder.ToTable("validationtestday");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .UseIdentityAlwaysColumn();

            builder.Property(x => x.DateDay)
                .HasColumnName("dateday");
            
            builder.Property(x => x.IsHoliday)
                .HasColumnName("isholiday");

            builder.Property(x => x.GrowthRate)
                .HasColumnName("growthrate");
        }
    }
}
