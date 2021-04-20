using StockSystem.Domain.Entities;
using StockSystem.Domain.Interfaces.Repository;
using StockSystem.Infra.Data.Context;
using StockSystem.Infra.Data.UnitOfWork;
using System;

namespace StockSystem.Infra.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserRepository(ApplicationDbContextAPI _context, IUnitOfWork unitOfWork) 
            : base(_context) { _unitOfWork = unitOfWork; }

        public User GetUserById(string id)
        {
            return base.GetById(Convert.ToInt32(id));
        }

        public User PostUser(User user)
        {
            base.Add(user);
            _unitOfWork.SaveChanges();

            return user;
        }
    }
}
