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

        public HelloWorldController()
        {
            DbContext = new TodoContext();
            DbContext.Database.EnsureCreated();
            DbContext.Add<Todo>(new Todo("someId", "Make ToDo API", "Learn making API with ASP.NET Core"));
            DbContext.SaveChanges();
        }
        
        [HttpGet]
        [Route("")]
        public ActionResult<Todo> HelloWorld(string title)
        {
            var todo = new Todo("test", title, "Some description");
            return todo;
        }
    }
}