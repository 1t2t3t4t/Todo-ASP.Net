using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApiCSharp.Database.Connection
{
    public class ConnectionProvider : IConnectionProvider
    {
        public string GetConnectionString(ConnectionEnvironment environment)
        {
            return GenerateConnectionString(new ConnectionModel("localhost", 3306, "todo", "boss", "admin"));
        }

        private string GenerateConnectionString(ConnectionModel model)
        {
            return "server=" + model.Server + ";port=" + model.Port + ";database=" + model.Database + ";user=" + model.User + ";password=" + model.Password;
        }
    }
}
