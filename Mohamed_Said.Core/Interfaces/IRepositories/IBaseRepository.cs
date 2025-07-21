using Mohamed_Said.Shared.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T?> GetByIdAsync(int id);

        Task<IEnumerable<T>> GetAllAsync();

        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, object>> orderByCriteria, string orderByDirection = OrderBy.Ascending, string[]? includes = null);


        Task<T?> FindAsync(Expression<Func<T, bool>> criteria, string[]? includes = null);

        Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> criteria, string[]? includes = null);

        Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> criteria, int skip, int take, string[]? includes = null);

        Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> criteria, int skip, int take, Expression<Func<T, object>> orderByCriteria, string orderByDirection = OrderBy.Ascending, string[]? includes = null);

        Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> criteria, Expression<Func<T, object>> orderByCriteria, string orderByDirection = OrderBy.Ascending, string[]? includes = null);

        T? Add(T entity);

        T? Update(T entity);

        T? Delete(T entity);

        Task<int> CountAsync();

        Task<int> CountAsync(Expression<Func<T, bool>> criteria);
    }
}
