using Microsoft.EntityFrameworkCore;
using TodoApiCSharp.Database.Connection;
using TodoApiCSharp.Database.Entity;

namespace TodoApiCSharp.Database
{
    public class TodoContext : DbContext
    {
        public DbSet<Todo> Todo { get; set; }

        private IConnectionProvider ConnectionProvider { get; }

        public TodoContext(IConnectionProvider connectionProvider)
        {
            ConnectionProvider = connectionProvider;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConnectionProvider.GetConnectionString(ConnectionEnvironment.Development));
        }
    }
}
