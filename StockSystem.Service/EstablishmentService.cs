using AutoMapper;
using StockSystem.Domain.Entities;
using StockSystem.Domain.Interfaces.Repository;
using StockSystem.Domain.Interfaces.Service;
using StockSystem.Domain.Request;
using StockSystem.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StockSystem.Service
{
    public class EstablishmentService : ServiceBase, IEstablishmentService
    {
        private readonly IEstablishmentRepository _establishmentRepository;
        private readonly IMapper _mapper;
        public EstablishmentService(IEstablishmentRepository establishmentRepository, IMapper mapper)
        {
            _establishmentRepository = establishmentRepository;
            _mapper = mapper;
        }

        public IEnumerable<EstablishmentResponse> GetAll() =>
            _mapper.Map<IEnumerable<EstablishmentResponse>>(_establishmentRepository.GetAll().ToList());

        public EstablishmentResponse GetEstablishmentById(string id) =>
            _mapper.Map<EstablishmentResponse>(_establishmentRepository.GetById(Convert.ToInt32(id)));

        public EstablishmentResponse PostEstablishment(EstablishmentRequest establishmentRequest) =>
            _mapper.Map<EstablishmentResponse>(_establishmentRepository.PostEstablishment(_mapper.Map<Establishment>(establishmentRequest)));
    }
}
