using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryServices.DAL
{
    /// <summary>
    /// Azure CosmosDB - SQLAPI/Document DB API communicator
    /// </summary>
    public class DBCommunicator<T> : IDBCommunicator<T>
    {
        public async Task<bool> Initialize()
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> GetItemsCollection()
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task SaveItem(T item)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

    }
}
