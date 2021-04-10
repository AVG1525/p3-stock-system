using Microsoft.EntityFrameworkCore;
using StockSystem.Domain.Interfaces.Repository;
using System.Linq;

namespace StockSystem.Infra.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly DbContext _context;

        public RepositoryBase(DbContext context)
        {
            _context = context;
        }

        public virtual T GetById(int id) => _context.Set<T>().Find(id);

        public virtual IQueryable<T> GetAll() => _context.Set<T>().AsNoTracking().AsQueryable();

        public void Add(T entity) => _context.Set<T>().Add(entity);

        public void Update(T entity) => _context.Entry(entity).State = EntityState.Modified;

        public void Delete(T entity) => _context.Entry(entity).State = EntityState.Deleted;
    }
}
