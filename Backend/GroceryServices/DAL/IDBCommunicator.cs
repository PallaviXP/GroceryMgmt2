using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GroceryServices.DAL
{
    public interface IDBCommunicator<T>
    {
        void Initialize(); //sync method
        Task<IEnumerable<T>> GetItemsCollection(Expression<Func<T, bool>> predicate);
        Task<T> GetItem(string id);
        Task<string> CreateItemAsync(T item);
        Task UpdateItemAsync(string id, T item);
        Task DeleteItemAsync(string id);
    }
}
