using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TransacaoFinanceira.Infrastructure.Repositories.Interfaces
{
    public interface ICommonRepository<T>
    {
        Task Add(T entity);
        Task AddOrUpdate(T entity,object primaryKeyValue);
        Task Update(T entity, object primaryKeyValue);
        Task Delete(T entity);

        Task<T> FindByIdAsync(int id);
        Task<List<T>> GetAllAsync();
        Task<List<T>> FindByWhereAsync(Expression<Func<T, bool>> predicate);
      
    }
}
