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
        public GroceryService()
        {
            DBCommunicator<Grocery>.Initialize();
        }

        public async Task<Grocery> Find(string id)
        {
            var res = await DBCommunicator<Grocery>.GetItemsCollection(x => x.Id == id);
            return res?.SingleOrDefault();
        }

        public async Task<List<Grocery>> GetAllPendingGroceryList()
        {
            var res = await DBCommunicator<Grocery>.GetItemsCollection(x => !x.IsComplete);
            return res?.ToList();
        }

        public async Task<string> SaveGroceryItem(Grocery item)
        {
            var result = await DBCommunicator<Grocery>.CreateItemAsync(item);
            return result.Id;
           
        }

        public async Task DeleteGroceryItem(string id)
        {
            await DBCommunicator<Grocery>.DeleteItemAsync(id);
        }

        public async Task Update(Grocery item)
        {
            var res = await DBCommunicator<Grocery>.GetItemsCollection(x => x.Id == item.Id);
            var itemToUpdate = res?.SingleOrDefault();

            if (itemToUpdate != null)
            {
                itemToUpdate.IsComplete = item.IsComplete;
                itemToUpdate.Name = item.Name;
                itemToUpdate.Quantity = item.Quantity;
                itemToUpdate.Specification = item.Specification;
                itemToUpdate.Description = item.Description;
                itemToUpdate.Category = item.Category;
                await DBCommunicator<Grocery>.UpdateItemAsync(item.Id, itemToUpdate);
            }
        }
    }
}
