using GeotekProject.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GeotekProject.Application.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        Task<T> GetById(string id);
        Task<bool> AddAsync(T entity);
        Task<bool> Update(T entity);
        Task<bool> RemoveAsync(string id);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method);
    }
}
