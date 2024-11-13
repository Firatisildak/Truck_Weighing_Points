using GeotekProject.Application.Interfaces;
using GeotekProject.Domain.Entities.Common;
using GeotekProject.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GeotekProject.Persistence.Repositories
{
    public class GenericRepository<T>(GeotekProjectDbContext context) : IRepository<T> where T : BaseEntity
    {
        private readonly GeotekProjectDbContext _context = context;

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll() => Table.AsNoTracking();

        public async Task<T> GetById(string id) => await Table.FirstOrDefaultAsync(s => s.Id == Guid.Parse(id));


        public async Task<bool> AddAsync(T entity)
        {
            await Table.AddAsync(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> RemoveAsync(string id)
        {
            var entity = await Table.FirstOrDefaultAsync(e => e.Id == Guid.Parse(id));
            if (entity == null) return false;

            Table.Remove(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Update(T entity)
        {
            Table.Update(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method) => Table.Where(method);
    }
}
