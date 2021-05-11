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
        public IStorage Storage { get; set; }

        public QueryService(IStorage storage)
        {
            this.Storage = storage;
        }

        public async Task<IEnumerable<T>> GetAll<T>() where T : class
        {
            return await Storage.Connection.QueryAllAsync<T>();
        }
        public async Task<IEnumerable<T>> GetOne<T>(Expression<Func<T, bool>> expression) where T : class
        {
            return await Storage.Connection.QueryAsync<T>(expression);
        }
    }
}
