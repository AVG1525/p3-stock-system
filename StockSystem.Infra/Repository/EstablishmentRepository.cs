using StockSystem.Domain.Entities;
using StockSystem.Domain.Interfaces.Repository;
using StockSystem.Infra.Data.Context;
using StockSystem.Infra.Data.UnitOfWork;

namespace StockSystem.Infra.Repository
{
    public class EstablishmentRepository : RepositoryBase<Establishment>, IEstablishmentRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        public EstablishmentRepository(ApplicationDbContextAPI _context, IUnitOfWork unitOfWork)
            : base(_context) { _unitOfWork = unitOfWork; }

        public Establishment GetEstablishmentById(int id) =>
            base.GetById(id);

        public Establishment PostEstablishment(Establishment newEstablishment)
        {
            base.Add(newEstablishment);
            _unitOfWork.SaveChanges();

            return newEstablishment;
        }
    }
}
