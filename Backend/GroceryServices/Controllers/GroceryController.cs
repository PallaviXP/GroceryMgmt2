using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryServices.Types;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GroceryServices.Controllers
{
    [Produces("application/json")]
    [Route("api/Grocery")]
    public class GroceryController : Controller
    {

        List<Grocery> _groceryList;

        public GroceryController()
        {
            _groceryList = new List<Grocery>() {
                new Grocery() { Id = 1, Name = "Jaggery", Quantity = 0, Weight = 1 },
                new Grocery() { Id = 2, Name = "Wheat", Quantity = 0, Weight = 5 },
                new Grocery() { Id = 3, Name = "Salt", Quantity = 0, Weight = 2 },
            };
        }

        // GET: api/Grocery
        [HttpGet]
        public IEnumerable<Grocery> Get()
        {          
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
