using StockSystem.Domain.Request;
using StockSystem.Domain.Response;
using System.Collections.Generic;

namespace StockSystem.Domain.Interfaces.Service
{
    public interface ISaleDayService : IServiceBase
    {
        IEnumerable<SaleDayResponse> GetAllSaleDay();
        SaleDayResponse GetSaleDayById(int id);
        SaleDayResponse PostSaleDay(SaleDayRequest saleDayRequest); 
    }
}
