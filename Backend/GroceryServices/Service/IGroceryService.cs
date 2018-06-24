using GroceryServices.Types;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GroceryServices.Service
{
    public interface IGroceryService
    {
        Task<List<Grocery>> GetAllPendingGroceryList();
        Task<string> SaveGroceryItem(Grocery item);
        Task<Grocery> Find(string id);
        Task DeleteGroceryItem(string id);
        Task Update(Grocery item);
    }
}
