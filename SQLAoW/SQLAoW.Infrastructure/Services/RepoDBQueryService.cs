using Microsoft.Extensions.Configuration;
using RepoDb;
using RepoDb.Enumerations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SQLAoW.Infrastructure.Services
{
    public class RepoDBQueryService : IQueryService
    {
        public IStorage Storage { get; set; }
        private IDbConnection DB { get; set; }

        public RepoDBQueryService(IStorage storage)
        {
            this.Storage = storage;
            DB = storage.CreateConnection();
        }

        public async Task<IEnumerable<T>> GetAll<T>() where T : class
        {
            return await DB.QueryAllAsync<T>();
        }
        public async Task<IEnumerable<T>> GetOne<T>(Expression<Func<T, bool>> expression) where T : class
        {
            return await DB.QueryAsync<T>(expression);
        }

        public async Task<IEnumerable<T>> GetAll<T>(string SQL, dynamic pars) where T : class
        {
            return null;//DB.ExecuteReaderAsync<T>(commandText: SQL, param: pars);
        }
    }
}
