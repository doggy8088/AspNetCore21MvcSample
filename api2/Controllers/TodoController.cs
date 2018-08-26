using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
// using api2.Models;

namespace api2.Controllers
{
    [Route("api/todo")]
    public class TodoController : Controller
    {
        public Todo0826Context db { get; }

        public TodoController(Todo0826Context db) {
            this.db = db;
        }

        // GET api/todo
        [HttpGet("")]
        public ActionResult<IEnumerable<TodoItems>> Gets()
        {
            return this.db.TodoItems;
        }

        // GET api/todo/5
        [HttpGet("{id}")]
        public ActionResult<string> GetById(int id)
        {
            return "value" + id;
        }

        // POST api/todo
        [HttpPost("")]
        public void Post([FromBody] string value) { }

        // PUT api/todo/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) { }

        // DELETE api/todo/5
        [HttpDelete("{id}")]
        public void DeleteById(int id) { }
    }
}