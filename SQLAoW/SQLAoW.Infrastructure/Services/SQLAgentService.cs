using Microsoft.Extensions.Configuration;
using RepoDb;
using RepoDb.Enumerations;
using SQLAoW.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLAoW.Infrastructure.Services
{
    public class SQLAgentService
    {
        private IStorage Storage { get; set; }
        private IDbConnection DB { get; set; }

        public SQLAgentService(IStorage storage)
        {
            this.Storage = storage;
            DB = storage.CreateConnection();
        }

        public async Task<bool> StartJob(string JobId)
        {
            var output = new DirectionalQueryField("RETURN_VALUE", typeof(int), ParameterDirection.ReturnValue);

            var pars = new[]
            {
                new QueryField("job_id",JobId),
                output
            };

            var executionResult = await DB.ExecuteNonQueryAsync("dbo.sp_start_job", pars, commandType: CommandType.StoredProcedure);

            return !(((int)output.Parameter.Value) != 0); //0: is success
        }
        public async Task<bool> StopJob(string JobId)
        {
            var output = new DirectionalQueryField("RETURN_VALUE", typeof(int), ParameterDirection.ReturnValue);

            var pars = new[]
            {
                new QueryField("job_id",JobId),
                output
            };

            var executionResult = await DB.ExecuteNonQueryAsync("dbo.sp_stop_job", pars, commandType: CommandType.StoredProcedure);

            return !(((int)output.Parameter.Value) != 0); //0: is success
        }

        /// <summary>
        /// See All Updateable Properties: https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-update-job-transact-sql?view=sql-server-ver15
        /// </summary>
        /// <param name="JobId"></param>
        /// <param name="Property"></param>
        /// <param name="Value"></param>
        /// <returns></returns>
        private async Task<bool> UpdateJob(string JobId, string Property, dynamic Value)
        {
            var output = new DirectionalQueryField("RETURN_VALUE", typeof(int), ParameterDirection.ReturnValue);

            var pars = new[]
            {
                new QueryField("job_id",JobId),
                new QueryField(Property,Value),
                output
            };

            var executionResult = await DB.ExecuteNonQueryAsync("dbo.sp_update_job", pars, commandType: CommandType.StoredProcedure);

            return !(((int)output.Parameter.Value) != 0); //0: is success
        }
        public async Task<bool> DisableJob(string JobId)
        {
            return await UpdateJob(JobId, "enabled", 0);
        }
        public async Task<bool> EnableJob(string JobId)
        {
            return await UpdateJob(JobId, "enabled", 1);
        }
        public async Task<bool> SetJobDescription(string JobId, string NewDescription)
        {
            return await UpdateJob(JobId, "description", NewDescription);
        }
        public async Task<bool> RenameJob(string JobId, string NewName)
        {
            return await UpdateJob(JobId, "new_name", NewName);
        }

        public async Task<JobActivity> GetLatestActivity(string JobId)
        {
            var sql = @"SELECT
                        ja.job_id as JobId,
                        j.name AS JobName,
                        j.description As JobDescription,
                        j.category_id as JobCategoryId,	
                        c.name AS JobCategoryName,
                        j.enabled as IsEnabled,
                        CAST(CASE WHEN ja.start_execution_date IS NOT NULL AND ja.stop_execution_date IS NULL THEN 1 ELSE 0 END AS BIT) AS IsCurrentlyRunning,
                        ISNULL(jh.run_status,-1) AS LastRunOutcome, /*-1: Unknown, 0: Failed, 1: Succeeded, 2:Retry, 3:Cancelled, 4:In Progress*/
                        ja.start_execution_date AS LastRunStartDateTime,
                        ja.stop_execution_date AS LastRunFinishDateTime,
                        ja.job_history_id AS LastRunJobHistoryId,            
                        jh.message as LastRunMessage,
                        jh.retries_attempted AS NumberOfRetryAttempts,
                        jh.run_duration AS LastRunDuration,
                        ja.next_scheduled_run_date NextRunDateTime,
                        CAST(IIF(SCH.schedule_id IS NULL,0,1) AS BIT) AS IsScheduled
                        FROM dbo.sysjobactivity ja 
                        LEFT JOIN dbo.sysjobhistory jh ON ja.job_history_id = jh.instance_id
                        JOIN dbo.sysjobs_view j on ja.job_id = j.job_id
                        LEFT JOIN dbo.syscategories C ON j.category_id=C.category_id
                        OUTER APPLY (
                        SELECT TOP 1 schedule_id FROM dbo.sysjobschedules
                        WHERE job_id=j.job_id
                        ) SCH
                        WHERE ja.job_id = @job_id 
                        AND ja.session_id = (SELECT MAX(session_id) FROM msdb.dbo.sysjobactivity)";

            var executionResult = await DB.ExecuteQueryAsync<JobActivity>(sql, new { job_id = JobId });

            return executionResult.FirstOrDefault();
        }

    }
}
