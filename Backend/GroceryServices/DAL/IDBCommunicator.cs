using System.Collections.Generic;
using System.Threading.Tasks;

namespace GroceryServices.DAL
{
    interface IDBCommunicator<T>
    {
        Task<bool> Initialize();
        Task<List<T>> GetItemsCollection();
        Task<T> GetItem(int id);
        Task SaveItem(T item);
        Task DeleteItem(int id);
    }
}
