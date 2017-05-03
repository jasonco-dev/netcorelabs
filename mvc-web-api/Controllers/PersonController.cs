using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using mvc_web_api.Models;
using mvc_web_api.Persistence;

namespace mvc_web_api.Controllers
{
    [Route("api/[controller]")]
    public class PersonController: Controller
    {
        private readonly PersonContext _personContext;
        public PersonController(PersonContext _context)
        {
            this._personContext = _context;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Person> Get()
        {
           // return new string[] { "value1", "value2" };
            return _personContext.Persons.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Person item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            _personContext.Add(item);

            return CreatedAtRoute(new { id = item.Key }, item);
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