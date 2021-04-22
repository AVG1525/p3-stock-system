using StockSystem.Domain.Entities;

namespace StockSystem.Domain.Interfaces.Repository
{
    public interface IEstablishmentRepository : IRepositoryBase<Establishment>
    {
        Establishment GetEstablishmentById(int id);
        Establishment PostEstablishment(Establishment newEstablishment);
    }
}
