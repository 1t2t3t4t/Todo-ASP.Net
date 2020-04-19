using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApiCSharp.Entity.Connection
{
    public class ConnectionModel
    {
        public string Server { get; set; }
        public int Port { get; set; }
        public string Database { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public ConnectionModel(string Server, int Port, string Database, string User, string Password)
        {
            this.Server = Server;
            this.Port = Port;
            this.Database = Database;
            this.User = User;
            this.Password = Password;
        }
    }
}
