using CG.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CG.Core
{
    public interface IRepository<T> where T : Entity
    {
        Task<T> Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task LogicDelete(int id);

        Task SaveChangesAsync();

        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetBy(Expression<Func<T, bool>> predicate);
    }
}
