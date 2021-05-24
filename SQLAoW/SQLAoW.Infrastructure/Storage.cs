using Microsoft.Extensions.Configuration;
using RepoDb;
using RepoDb.Enumerations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SQLAoW.Infrastructure
{
    public class Storage : IStorage
    {
        private readonly IConfiguration configuration;
        public string ConnectionStringName { get; private set; } = "Default";
        public string ConnectionString { get; private set; }

        public Storage(IConfiguration configuration)
        {
            this.configuration = configuration;
            SqlServerBootstrap.Initialize();
            Converter.ConversionType = ConversionType.Automatic;
            ConnectionString = configuration.GetConnectionString(ConnectionStringName);
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(ConnectionString);
        }

    }
}
