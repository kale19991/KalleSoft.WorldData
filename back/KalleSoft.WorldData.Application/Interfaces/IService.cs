using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalleSoft.WorldData.Application.Interfaces
{
    public interface IService<TModel, TKey>
        where TModel : class
        where TKey : IComparable
    {
        Task<TModel> InsertAsync(TModel entity);
        Task<TModel> UpdateAsync(TModel entity, TKey id);
        Task<bool> DeleteAsync(TKey id);
        Task<TModel> GetByIdAsync(TKey id);
        Task<List<TModel>> GetAllAsync();
    }
}