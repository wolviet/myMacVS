using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myMacVS.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace myMacVS.Controllers
{
    [Route("api/[controller]")]
    public class CarController : Controller
    {
        private readonly CarContext _context;


        public CarController(CarContext context)
        {
            _context = context;
            if(_context.Cars.Count() == 0)
            {
                _context.Cars.Add((new Car{ Make="Mazda",CarModel="Takuya",Colour="Aluminium"}));
                _context.Cars.Add(new Car{ Make="BMW",Colour="Black",CarModel="% Series"});
                _context.SaveChanges();
            }
        }


        // GET: api/values
        [HttpGet]
        public IEnumerable<Car> GetAll()
        {
            return _context.Cars.ToList();
        }
                                        

        // GET api/values/5
        [HttpGet("{id}", Name="GetCar")]
        public IActionResult GetById(long id)
        {
            var item = _context.Cars.FirstOrDefault(t => t.CarId == id);
            if(item == null)
            {
                return NotFound();
            }

            return new ObjectResult(item);

            //return "value";
        }

        // POST api/values
        [HttpPost]
        public IActionResult Create([FromBody] Car item)
        {
            if (item == null)
                return BadRequest();
            

            _context.Cars.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("GetCar", new { id = item.CarId }, item);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
