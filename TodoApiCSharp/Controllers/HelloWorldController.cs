using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApiCSharp.Entity;
using TodoApiCSharp.Models;

namespace TodoApiCSharp.Controllers
{
    [ApiController]
    public class HelloWorldController : ControllerBase
    {

        private TodoContext DbContext { get; }

        public HelloWorldController(TodoContext DbContext)
        {
            this.DbContext = DbContext;
            DbContext.Database.EnsureCreated();
        }
        
        [HttpGet]
        [Route("")]
        public ActionResult<Todo> HelloWorld(string title)
        {
            var todo = new Todo(title, "Some description");
            DbContext.Add<Todo>(todo);
            DbContext.SaveChanges();
            return todo;
        }
    }
}