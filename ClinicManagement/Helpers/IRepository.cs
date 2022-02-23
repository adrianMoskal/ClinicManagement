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
        IEnumerable<T> GetAll();
        Task<T> GetById(long id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void InsertRange(IEnumerable<T> entities);
        //IQueryable<T> FindAsync(Expression<Func<T, bool>> predicate);
    }
}
