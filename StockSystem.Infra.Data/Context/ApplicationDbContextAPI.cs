using Microsoft.EntityFrameworkCore;
using StockSystem.Domain.Entities;
using StockSystem.Infra.Data.Mappings;

namespace StockSystem.Infra.Data.Context
{
    public class ApplicationDbContextAPI : DbContext
    {
        public ApplicationDbContextAPI(DbContextOptions<ApplicationDbContextAPI> options)
            : base(options)
        { }

        public DbSet<DescriptionRawMaterial> DescriptionRawMaterial { get; set; }
        public DbSet<Establishment> Establishment { get; set; }
        public DbSet<HistoryRawMaterial> HistoryRawMaterial { get; set; }
        public DbSet<RawMaterial> RawMaterial { get; set; }
        public DbSet<SaleDay> SaleDay { get; set; }
        public DbSet<StatisticsDay> StatisticsDay { get; set; }
        public DbSet<StatisticsRawMaterial> StatisticsRawMaterial { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<ValidationTestDay> ValidationTestDay { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DescriptionRawMaterialMapping());
            modelBuilder.ApplyConfiguration(new EstablishmentMapping());
            modelBuilder.ApplyConfiguration(new HistoryRawMaterialMapping());
            modelBuilder.ApplyConfiguration(new RawMaterialMapping());
            modelBuilder.ApplyConfiguration(new SaleDayMapping());
            modelBuilder.ApplyConfiguration(new StatisticsDayMapping());
            modelBuilder.ApplyConfiguration(new StatisticsRawMaterialMapping());
            modelBuilder.ApplyConfiguration(new UserMapping());
            modelBuilder.ApplyConfiguration(new ValidationTestDayMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
