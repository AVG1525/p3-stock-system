using AutoMapper;
using StockSystem.Domain.Entities;
using StockSystem.Domain.Interfaces.Repository;
using StockSystem.Domain.Interfaces.Service;
using StockSystem.Domain.Request;
using StockSystem.Domain.Response;
using System.Collections.Generic;
using System.Linq;

namespace StockSystem.Service
{
    public class SaleDayService : ServiceBase, ISaleDayService
    {
        private readonly IMapper _mapper;
        private readonly ISaleDayRepository _saleDayRepository;
        public SaleDayService(IMapper mapper,
            ISaleDayRepository saleDayRepository)
        {
            _mapper = mapper;
            _saleDayRepository = saleDayRepository;
        }

        public IEnumerable<SaleDayResponse> GetAllSaleDay() =>
            _mapper.Map<IEnumerable<SaleDayResponse>>(_saleDayRepository.GetAll().ToList());

        public SaleDayResponse GetSaleDayById(int id) =>
            _mapper.Map<SaleDayResponse>(_saleDayRepository.GetById(id));

        public SaleDayResponse PostSaleDay(SaleDayRequest saleDayRequest) =>
            _mapper.Map<SaleDayResponse>(_saleDayRepository.PostSaleDay(_mapper.Map<SaleDay>(saleDayRequest)));
    }
}
