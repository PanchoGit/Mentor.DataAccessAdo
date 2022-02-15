using System.Data;
using Autofac;
using MySqlConnector;

namespace DataAccessAdo.Infrastructures
{
    public class DatabaseModule : Module
    {
        private readonly ConfigurationManager configurationManager;

        public DatabaseModule(ConfigurationManager configurationManager)
        {
            this.configurationManager = configurationManager;
        }

        protected override void Load(ContainerBuilder builder)
        {
            var connectionString = configurationManager["ConnectionStrings:Default"];

            builder.Register<MySqlConnection>(c => new MySqlConnection(connectionString))
                .InstancePerLifetimeScope();
        }
    }
}
