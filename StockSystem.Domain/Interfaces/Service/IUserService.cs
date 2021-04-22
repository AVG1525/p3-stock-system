using StockSystem.Domain.Request;
using StockSystem.Domain.Response;
using System.Collections.Generic;

namespace StockSystem.Domain.Interfaces.Service
{
    public interface IUserService : IServiceBase
    {
        IEnumerable<UserResponse> GetAll();
        UserResponse GetUserById(string id);
        UserResponse PostUser(UserRequest userResquest);
    }
}
