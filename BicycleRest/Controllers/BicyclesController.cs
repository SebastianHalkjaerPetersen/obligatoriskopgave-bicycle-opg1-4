using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using obligatorisk_opgave;

namespace BicycleRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BicyclesController : ControllerBase
    {

        private static List<Bicycle> BicyclesList = new List<Bicycle>()
        {
            new Bicycle(1, "Green", 400, 7),
            new Bicycle(2, "Green", 1000, 21),
            new Bicycle(3, "Blue", 5000, 32),
            new Bicycle(4, "Red", 300, 3)
        };


        // GET: api/Bicycles
        [HttpGet]
        public IEnumerable<Bicycle> Get()
        {
            return BicyclesList;
        }

        // GET: api/Bicycles/5
        [HttpGet("{id}", Name = "Get")]
        public Bicycle Get(int id)
        {
            return BicyclesList.Find(b => b.Id == id);
        }

        // POST: api/Bicycles
        [HttpPost]
        public void Post([FromBody] Bicycle value)
        {
            BicyclesList.Add(value);
        }

        // PUT: api/Bicycles/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Bicycle value)
        {
            Bicycle b1 = BicyclesList.Find(b => b.Id == id);
               
            if(b1 != null)
            {
                b1.Id = value.Id;
                b1.Colour = value.Colour;
                b1.Price = value.Price;
                b1.Gear = value.Gear;
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Bicycle b1 = BicyclesList.Find(b => b.Id == id);
            if (b1 != null)
            {
                BicyclesList.Remove(b1);
            }
            
        }
    }
}
