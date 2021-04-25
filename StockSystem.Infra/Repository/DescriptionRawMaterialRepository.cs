using StockSystem.Domain.Entities;
using StockSystem.Domain.Interfaces.Repository;
using StockSystem.Infra.Data.Context;
using StockSystem.Infra.Data.UnitOfWork;

namespace StockSystem.Infra.Repository
{
    public class DescriptionRawMaterialRepository : RepositoryBase<DescriptionRawMaterial>, IDescriptionRawMaterialRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        public DescriptionRawMaterialRepository(ApplicationDbContextAPI _context, IUnitOfWork unitOfWork)
            : base(_context) { _unitOfWork = unitOfWork; }

        public DescriptionRawMaterial PostDescriptionRawMaterial(DescriptionRawMaterial newDescriptionRawMaterial)
        {
            base.Add(newDescriptionRawMaterial);
            _unitOfWork.SaveChanges();

            return newDescriptionRawMaterial;
        }
    }
}
