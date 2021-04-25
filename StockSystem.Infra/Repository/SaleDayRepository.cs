using StockSystem.Domain.Entities;
using StockSystem.Domain.Interfaces.Repository;
using StockSystem.Infra.Data.Context;
using StockSystem.Infra.Data.UnitOfWork;

namespace StockSystem.Infra.Repository
{
    public class SaleDayRepository : RepositoryBase<SaleDay>, ISaleDayRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        public SaleDayRepository(ApplicationDbContextAPI _context, IUnitOfWork unitOfWork)
            : base(_context) { _unitOfWork = unitOfWork; }

        public SaleDay PostSaleDay(SaleDay newSaleDay)
        {
            base.Add(newSaleDay);
            _unitOfWork.SaveChanges();

            return newSaleDay;
        }
    }
}
