using StockSystem.Infra.Data.Context;

namespace StockSystem.Infra.Data.UnitOfWork
{
    public class UnitOfWorkAPI : IUnitOfWork
    {
        private readonly ApplicationDbContextAPI _context;
        public UnitOfWorkAPI(ApplicationDbContextAPI context)
        {
            _context = context;
        }

        public bool SaveChanges() => _context.SaveChanges() > 0;
    }
}
