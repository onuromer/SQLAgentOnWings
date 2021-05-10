using Microsoft.Extensions.Configuration;
using RepoDb;
using RepoDb.Enumerations;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SQLAoW.Infrastructure.Services
{
    public class QueryService : IQueryService
    {
        private readonly IConfiguration configuration;
        public string ConnectionStringName { get; set; } = "Default";

        public QueryService(IConfiguration configuration)
        {
            this.configuration = configuration;
            SqlServerBootstrap.Initialize();
            Converter.ConversionType = ConversionType.Automatic;
        }

        public async Task<IEnumerable<T>> GetAll<T>() where T : class
        {
            using (var connection = new SqlConnection(configuration.GetConnectionString(ConnectionStringName)))
            {
                return await connection.QueryAllAsync<T>();
            }
        }
        public async Task<IEnumerable<T>> GetOne<T>(Expression<Func<T, bool>> expression) where T : class
        {
            using (var connection = new SqlConnection(configuration.GetConnectionString(ConnectionStringName)))
            {
                return await connection.QueryAsync<T>(expression);
            }
        }
    }
}
