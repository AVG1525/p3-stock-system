using StockSystem.Domain.Entities;
using StockSystem.Domain.Interfaces.Repository;
using StockSystem.Infra.Data.Context;
using StockSystem.Infra.Data.UnitOfWork;

namespace StockSystem.Infra.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserRepository(ApplicationDbContextAPI _context, IUnitOfWork unitOfWork) 
            : base(_context) { _unitOfWork = unitOfWork; }

        public User PostUser(User user)
        {
            base.Add(user);
            _unitOfWork.SaveChanges();

            return user;
        }
    }
}
