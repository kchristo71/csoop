using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using OOP.DL.Contracts;

namespace OOP.DataLayer.Implementations
{
    public abstract class BaseDatabaseContext
    {
        public string ConnectionString { get; }

        protected BaseDatabaseContext(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected abstract IDbConnection GetConnection();
    }
}
