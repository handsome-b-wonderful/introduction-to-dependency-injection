using System.Data.Common;
using NPoco;
using NPoco.FluentMappings;
using System.Data.SqlClient;

namespace Pets.Database
{
    public static class DataFactory
    {
        public static DatabaseFactory DbFactory { get; set; }

        public static void Setup(string connectionString)
        {
            var fluentConfig = FluentMappingConfiguration.Configure(new DataMappings());
            DbFactory = DatabaseFactory.Config(x =>
            {
                x.UsingDatabase(() =>
                    new NPoco.Database(connectionString, DatabaseType.SqlServer2012, SqlClientFactory.Instance));
                x.WithFluentConfig(fluentConfig);
            });
        }
    }
}
