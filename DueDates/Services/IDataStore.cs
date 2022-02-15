using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DueDates.Services
{
    public interface IDataStore<T>
    {
        Task<bool> AddItemAsync(T bill);
        Task<bool> UpdateItemAsync(T bill);
        Task<bool> DeleteItemAsync(string id);
        Task<T> GetItemAsync(string id);
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
    }
}
