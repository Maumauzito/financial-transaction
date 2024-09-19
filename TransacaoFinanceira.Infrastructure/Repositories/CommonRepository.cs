using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TransacaoFinanceira.Infrastructure.Data;
using TransacaoFinanceira.Infrastructure.Repositories.Interfaces;

namespace TransacaoFinanceira.Infrastructure.Repositories
{
    public abstract class CommonRepository<T> : ICommonRepository<T> where T : class
    {
        protected readonly TransacaoFinanceiraContex _contex;

        public CommonRepository(TransacaoFinanceiraContex contex)
        {
            _contex = contex;
        }

        public virtual async Task<List<T>> FindByWhereAsync(Expression<Func<T, bool>> predicate)
        {
            return await _contex.Set<T>()
                .AsNoTracking() 
                .Where(predicate).ToListAsync();
        }
        public virtual async Task<T> FindByIdAsync(int id)
        {
            return await _contex.Set<T>().FindAsync(id);
        }

        public virtual async Task<List<T>> GetAllAsync()
        {
            return await _contex.Set<T>().ToListAsync();
        }

        public virtual async Task Add(T entity)
        {
            await _contex.Set<T>().AddAsync(entity);
            await _contex.SaveChangesAsync();
        }

        public virtual async Task AddOrUpdate(T entity, object primaryKeyValue)
        {
            var existEntity = await _contex.Set<T>().FindAsync(primaryKeyValue);
            if (existEntity != null)
            {
                _contex.Entry(existEntity).CurrentValues.SetValues(entity);
                _contex.Entry(existEntity).State = EntityState.Modified;
            }
            else
            {
                await _contex.Set<T>().AddAsync(entity);
            }

            await _contex.SaveChangesAsync();
        }

        public virtual async Task Update(T entity, object primaryKeyValue)
        {
            var oldEntity = await _contex.Set<T>().FindAsync(primaryKeyValue);
            if (oldEntity != null) 
            {
                _contex.Entry(oldEntity).CurrentValues.SetValues(entity);
                _contex.Entry(oldEntity).State = EntityState.Modified;
                await _contex.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentException("Entity not Found");
            }

        }

        public virtual async Task Delete(T entity)
        {
            _contex.Set<T>().Remove(entity);
            await _contex.SaveChangesAsync();
        }


    }
}
