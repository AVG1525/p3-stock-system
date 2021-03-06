using System.Linq;

namespace StockSystem.Domain.Interfaces.Repository
{
    public interface IRepositoryBase<T> where T : class
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
    }
}
