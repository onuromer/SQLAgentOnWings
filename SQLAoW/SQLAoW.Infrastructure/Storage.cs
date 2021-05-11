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
    public class Storage : IDisposable, IStorage
    {
        private readonly IConfiguration configuration;
        public string ConnectionStringName { get; set; } = "Default";
        public IDbConnection Connection { get; set; }

        public Storage(IConfiguration configuration)
        {
            this.configuration = configuration;
            SqlServerBootstrap.Initialize();
            Converter.ConversionType = ConversionType.Automatic;

            Connection = new SqlConnection(configuration.GetConnectionString(ConnectionStringName));
        }

        public void Dispose()
        {
            Connection = null;
        }
    }
}
