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
    }
}
