using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApiCSharp.Entity.Connection
{
    public enum ConnectionEnvironment
    {
        Production,
        Staging,
        Development,
        Test
    }

    public interface IConnectionProvider
    {
        public string GetConnectionString(ConnectionEnvironment environment);
    }
}
