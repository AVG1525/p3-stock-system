using StockSystem.Domain.Request;
using StockSystem.Domain.Response;

namespace StockSystem.Domain.Interfaces.Service
{
    public interface ICloseDayService : IServiceBase
    {
        CloseDayResponse PostCloseDay(CloseDayRequest closeDayRequest);
    }
}
