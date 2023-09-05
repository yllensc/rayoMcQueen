using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Domine.Entities;

namespace Domine.Interfaces
{
    public interface IGeneric<T> where T : BaseEntity
    {
        Task<T> GetEntityById(int id);
        Task<IEnumerable<T>> GetAllAsync();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        //Task<(int totalRegistros, IEnumerable<T> registros)> GetAllAsync(int pageIndex, int pageSize, string search);
        void Update(T entity);
        void Delete(T entity);
        void DeleteRange (IEnumerable<T> entities);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);

    }
}