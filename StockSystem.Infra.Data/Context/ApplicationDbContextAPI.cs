using Microsoft.EntityFrameworkCore;

namespace StockSystem.Infra.Data.Context
{
    public class ApplicationDbContextAPI : DbContext
    {
        public ApplicationDbContextAPI(DbContextOptions<ApplicationDbContextAPI> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
