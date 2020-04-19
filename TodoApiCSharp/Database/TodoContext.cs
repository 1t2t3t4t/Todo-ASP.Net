using Microsoft.EntityFrameworkCore;
using TodoApiCSharp.Database.Connection;
using TodoApiCSharp.Database.Entity;

namespace TodoApiCSharp.Database
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
