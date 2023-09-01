using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KalleSoft.WorldData.Domain.Models.Entities;

namespace KalleSoft.WorldData.Infrastructure.Interfeces
{
    public interface IRepository<TEntity, TKey>
        where TEntity : Entity<TKey>
        where TKey : IComparable
    {
        Task<TEntity> InsertAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity, TKey id);
        Task<bool> DeleteAsync(TKey id);
        Task<TEntity> GetByIdAsync(TEntity entity, TKey id);
        Task<List<TEntity>> GetAllAsync();
    }
}