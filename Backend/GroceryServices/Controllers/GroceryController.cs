using GroceryServices.Service;
using GroceryServices.Types;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GroceryServices.Controllers
{
    [Produces("application/json")]
    [Route("api/Grocery")]
    public class GroceryController : Controller
    {
        IGroceryService _groceryService;
        List<Grocery> _groceryList;

        public GroceryController()
        {
            _groceryService = new GroceryService();           
        }

        // GET: api/Grocery
        [HttpGet]
        public async Task<IEnumerable<Grocery>> Get()
        {     
            _groceryList = await _groceryService.GetAllPendingGroceryList();
            return _groceryList;
        }

        // GET: api/Grocery/5
        [HttpGet("{id}", Name = "Get")]
        public Grocery Get(int id)
        {
            return _groceryList[id-1];
        }
        
        // POST: api/Grocery
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Grocery/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
