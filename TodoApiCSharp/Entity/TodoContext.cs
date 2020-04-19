using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApiCSharp.Entity.Connection;
using TodoApiCSharp.Models;

namespace TodoApiCSharp.Entity
{
    public class TodoContext : DbContext
    {
        public DbSet<Todo> Todo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConnectionProvider connectionProvider = new ConnectionProvider();
            optionsBuilder.UseMySql(connectionProvider.GetConnectionString(ConnectionEnvironment.Development));
        }

    }
}
