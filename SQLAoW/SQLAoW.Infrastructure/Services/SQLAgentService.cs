using Microsoft.Extensions.Configuration;
using RepoDb;
using RepoDb.Enumerations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace SQLAoW.Infrastructure.Services
{
    public class SQLAgentService : ISQLAgentService
    {
        public IStorage Storage { get; set; }

        public SQLAgentService(IStorage storage)
        {
            this.Storage = storage;
        }

        public async Task<bool> RunJob(string JobId)
        {
            var output = new DirectionalQueryField("RETURN_VALUE", typeof(int), ParameterDirection.ReturnValue);

            var pars = new[]
            {
                new QueryField("job_id",JobId),
                output
            };

            var executionResult = await Storage.Connection.ExecuteNonQueryAsync("dbo.sp_start_job", pars, commandType: CommandType.StoredProcedure);

            return !(((int)output.Parameter.Value)!=0); //0: is success
        }
    }
}
