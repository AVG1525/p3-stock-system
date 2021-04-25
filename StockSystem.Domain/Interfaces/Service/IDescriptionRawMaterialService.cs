using StockSystem.Domain.Request;
using StockSystem.Domain.Response;
using System.Collections.Generic;

namespace StockSystem.Domain.Interfaces.Service
{
    public interface IDescriptionRawMaterialService : IServiceBase
    {
        IEnumerable<DescriptionRawMaterialResponse> GetAllDescriptionRawMaterial();
        DescriptionRawMaterialResponse GetDescriptionRawMaterialById(int id);
        DescriptionRawMaterialResponse PostDescriptionRawMaterial(DescriptionRawMaterialRequest descriptionRawMaterialRequest);
    }
}
