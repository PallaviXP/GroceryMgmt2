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
        public async Task<IActionResult> Get()
        {
            var groceryList = await _groceryService.GetAllPendingGroceryList();
            return Ok(groceryList);
        }

        // GET: api/Grocery/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> Get(string id)
        {
            var item = await _groceryService.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }
        
        // POST: api/Grocery
        [HttpPost]
        public async Task<IActionResult> CreateGroceryEntry([FromBody]Grocery item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            //Grocery item1 = new Grocery() { Id="4", Name = "OldRice", Category = "Random Need", IsComplete = false, Quantity = "0", Specification = "Nothing" };
            var resultId = await _groceryService.SaveGroceryItem(item);
            return CreatedAtRoute(
                routeName: "Get",
                routeValues: new { id = resultId },
                value: item);
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
