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

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetBy(Expression<Func<T, bool>> predicate)
        { 
            return await _context.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return (T)await _context.FindAsync(typeof(T), id);
        }

        public async Task LogicDelete(int id)
        {
            var entity = await GetById(id);
            entity.IsEnabled = !entity.IsEnabled;
            await Update(entity);
        }

        public Task Update(T entity)
        {
            _context.Update(entity);
            entity.LastUpdate = DateTime.Now;

            return Task.CompletedTask;
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
