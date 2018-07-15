using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryServices.DAL;
using GroceryServices.Types;
namespace GroceryServices.Service
{
    public class GroceryService : IGroceryService
    {
        IDBCommunicator<Grocery> _dBCommunicator;

        public GroceryService(IDBCommunicator<Grocery> dBCommunicator)
        {
            _dBCommunicator = dBCommunicator;
            _dBCommunicator.Initialize();
        }

        public async Task<Grocery> Find(string id)
        {
            var res = await _dBCommunicator.GetItemsCollection(x => x.Id == id);
            return res?.SingleOrDefault();
        }

        public async Task<List<Grocery>> GetAllPendingGroceryList()
        {
            var res = await _dBCommunicator.GetItemsCollection(x=> x.Name != "");
            return res?.ToList();
        }

        public async Task<string> SaveGroceryItem(Grocery item)
        {
            return await _dBCommunicator.CreateItemAsync(item);
        }

        public async Task DeleteGroceryItem(string id)
        {
            await _dBCommunicator.DeleteItemAsync(id);
        }

        public async Task Update(Grocery item)
        {
            var res = await _dBCommunicator.GetItemsCollection(x => x.Id == item.Id);
            var itemToUpdate = res?.SingleOrDefault();

            if (itemToUpdate != null)
            {
                itemToUpdate.IsComplete = item.IsComplete;
                itemToUpdate.Name = item.Name;
                itemToUpdate.Quantity = item.Quantity;
                itemToUpdate.Specification = item.Specification;
                itemToUpdate.Description = item.Description;
                itemToUpdate.Category = item.Category;
                await _dBCommunicator.UpdateItemAsync(item.Id, itemToUpdate);
            }
        }
    }
}
