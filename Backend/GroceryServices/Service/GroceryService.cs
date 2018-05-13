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

        public async Task<List<Grocery>> GetAllPendingGroceryList()
        {
            var res = await DBCommunicator<Grocery>.GetItemsCollection(x => !x.IsComplete);
            return res?.ToList();
        }
    }
}
