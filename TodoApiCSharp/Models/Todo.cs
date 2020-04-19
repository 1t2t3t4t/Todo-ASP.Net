using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApiCSharp.Models
{
    public class Todo
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Todo(string Id, string Title, string Description)
        {
            this.Id = Id;
            this.Title = Title;
            this.Description = Description;
        }
    }
}
