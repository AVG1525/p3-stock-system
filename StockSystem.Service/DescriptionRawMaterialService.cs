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
    public class DescriptionRawMaterialService : ServiceBase, IDescriptionRawMaterialService
    {
        private readonly IMapper _mapper;
        private readonly IDescriptionRawMaterialRepository _descriptionRawMaterialRepository;
        public DescriptionRawMaterialService(IMapper mapper,
            IDescriptionRawMaterialRepository descriptionRawMaterialRepository)
        {
            _mapper = mapper;
            _descriptionRawMaterialRepository = descriptionRawMaterialRepository;
        }

        public IEnumerable<DescriptionRawMaterialResponse> GetAllDescriptionRawMaterial() =>
            _mapper.Map<IEnumerable<DescriptionRawMaterialResponse>>(_descriptionRawMaterialRepository.GetAll().ToList());

        public DescriptionRawMaterialResponse GetDescriptionRawMaterialById(int id) =>
            _mapper.Map<DescriptionRawMaterialResponse>(_descriptionRawMaterialRepository.GetById(id));

        public DescriptionRawMaterialResponse PostDescriptionRawMaterial(DescriptionRawMaterialRequest descriptionRawMaterialRequest) =>
            _mapper.Map<DescriptionRawMaterialResponse>(_descriptionRawMaterialRepository.PostDescriptionRawMaterial(_mapper.Map<DescriptionRawMaterial>(descriptionRawMaterialRequest)));
    }
}
