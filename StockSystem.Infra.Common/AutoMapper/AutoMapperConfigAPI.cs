using AutoMapper;
using StockSystem.Domain.Entities;
using StockSystem.Domain.Request;
using StockSystem.Domain.Response;

namespace StockSystem.Infra.Common.AutoMapper
{
    public class AutoMapperConfigAPI : Profile
    {
        public AutoMapperConfigAPI()
        {
            AutoMapperRequestForEntity();
            AutoMapperEntityForResponse();
        }

        void AutoMapperRequestForEntity() 
        {
            CreateMap<UserRequest, User>();
            CreateMap<EstablishmentRequest, Establishment>();
            CreateMap<SaleDayRequest, SaleDay>();
        }

        void AutoMapperEntityForResponse()
        {
            CreateMap<User, UserResponse>();
            CreateMap<Establishment, EstablishmentResponse>();
            CreateMap<SaleDay, SaleDayResponse>();
        }
    }
}
