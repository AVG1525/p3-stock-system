using StockSystem.Domain.Request;
using StockSystem.Domain.Response;

namespace StockSystem.Domain.Interfaces.Service
{
    public interface IUserService : IServiceBase
    {
        UserResponse GetUserById(string id);
        UserResponse PostUser(UserResquest userResquest);
    }
}
