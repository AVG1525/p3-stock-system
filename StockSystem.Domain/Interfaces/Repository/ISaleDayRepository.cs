using StockSystem.Domain.Entities;

namespace StockSystem.Domain.Interfaces.Repository
{
    public interface ISaleDayRepository : IRepositoryBase<SaleDay>
    {
        SaleDay PostSaleDay(SaleDay newSaleDay);
    }
}
