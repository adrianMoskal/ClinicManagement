using ClinicManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ClinicManagement.Helpers
{
    public interface IRepository<T> where T: BaseEntity
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(long id);
        Task<T> FindOneAsync(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
        void Insert(T entity);
        void InsertRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        void Update(T entity); 
    }
}
