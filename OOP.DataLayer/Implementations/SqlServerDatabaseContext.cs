using System.Data;
using System.Data.SqlClient;

namespace OOP.DataLayer.Implementations
{
    public class SqlServerDatabaseContext: BaseDatabaseContext
    {
        public SqlServerDatabaseContext(string connectionString) : base(connectionString)
        {
        }

        protected override IDbConnection GetConnection()
        {
          return new SqlConnection(ConnectionString);
        }
    }
}
