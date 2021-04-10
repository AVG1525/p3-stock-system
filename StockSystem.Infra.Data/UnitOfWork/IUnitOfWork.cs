namespace StockSystem.Infra.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        bool SaveChanges();
    }
}
