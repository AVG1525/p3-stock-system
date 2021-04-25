using AutoMapper;
using StockSystem.Domain.Interfaces.Service;
using StockSystem.Domain.Request;
using StockSystem.Domain.Response;

namespace StockSystem.Service
{
    public class CloseDayService : ServiceBase, ICloseDayService
    {
        private readonly IMapper _mapper;
        public CloseDayService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public CloseDayResponse PostCloseDay(CloseDayRequest closeDayRequest)
        {
            throw new System.NotImplementedException();
        }
    }
}
