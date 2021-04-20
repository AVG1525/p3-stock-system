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
            CreateMap<UserResquest, User>();
        }

        void AutoMapperEntityForResponse()
        {
            CreateMap<User, UserResponse>();
        }
    }
}
