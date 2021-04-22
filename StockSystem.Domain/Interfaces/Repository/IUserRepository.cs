using StockSystem.Domain.Entities;

namespace StockSystem.Domain.Interfaces.Repository
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        User PostUser(User user);
    }
}
