using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using MySqlConnector;

namespace DataAccessAdo.Repositories
{
    public class RepositoryBase
    {
        private readonly MySqlConnection connection;

        public RepositoryBase(MySqlConnection connection)
        {
            this.connection = connection;
        }

        protected MySqlConnection GetConnection()
        {
            return this.connection;
        }

    }
}
