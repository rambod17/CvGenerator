using CG.Core;
using CG.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CG.Infrastructure
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }

        public async Task<T> Add(T entity)
        {
            await _context.AddAsync(entity);
            return entity;
        }

        public Task Delete(T entity)
        {
            _context.Remove(entity);

            return Task.CompletedTask;
        }

        public async Task<IEnumerable<T>> GetAll<TEntity>() where TEntity : Entity
        {
            return (IEnumerable<T>)await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetBy<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : Entity
        {
            return (IEnumerable<T>)await _context.Set<TEntity>().Where(predicate).ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return (T)await _context.FindAsync(typeof(T), id);
        }

        public Task LogicDelete(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(T entity)
        {
            _context.Update(entity);

            return Task.CompletedTask;
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
