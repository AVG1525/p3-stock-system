using StockSystem.Domain.Request;
using StockSystem.Domain.Response;
using System.Collections.Generic;

namespace StockSystem.Domain.Interfaces.Service
{
    public interface IEstablishmentService : IServiceBase
    {
        IEnumerable<EstablishmentResponse> GetAll();
        EstablishmentResponse GetEstablishmentById(string id);
        EstablishmentResponse PostEstablishment(EstablishmentRequest establishmentRequest);
    }
}
