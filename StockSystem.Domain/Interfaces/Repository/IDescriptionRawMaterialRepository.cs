using StockSystem.Domain.Entities;

namespace StockSystem.Domain.Interfaces.Repository
{
    public interface IDescriptionRawMaterialRepository : IRepositoryBase<DescriptionRawMaterial>
    {
        DescriptionRawMaterial PostDescriptionRawMaterial(DescriptionRawMaterial newDescriptionRawMaterial);
    }
}
