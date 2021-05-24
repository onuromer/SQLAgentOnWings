using RepoDb.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SQLAoW.Infrastructure.Models
{
    public class JobActivity
    {
        [Key]
        [Map("[JobId]")]
        public string JobId { get; set; }
        [Map("[JobName]")]
        public string Name { get; set; }

        [Map("[JobDescription]")]
        public string Description { get; set; }

        [Map("[JobCategoryId]")]
        public int CategoryId { get; set; }

        [Map("[JobCategoryName]")]
        public string CategoryName { get; set; }

        [Map("[IsEnabled]")]
        public bool Enabled { get; set; }

        [Map("[IsCurrentlyRunning]")]
        public bool IsRunning { get; set; }

        [Map("[IsScheduled]")]
        public bool IsScheduled { get; set; }

        [Map("[LastRunOutcome]")]
        public int LastRunOutcome { get; set; }

        [Map("[LastRunStartDateTime]")]
        public DateTime? LastRunStartDateTime { get; set; }

        [Map("[LastRunFinishDateTime]")]
        public DateTime? LastRunFinishDateTime { get; set; }

        [Map("[LastRunJobHistoryId]")]
        public int? LastRunJobHistoryId { get; set; }

        [Map("[LastRunMessage]")]
        public string LastRunMessage { get; set; }

        [Map("[NumberOfRetryAttempts]")]
        public int? NumberOfRetryAttempts { get; set; }

        [Map("[LastRunDuration]")]
        public int? LastRunDurationSeconds { get; set; }

        [Map("[NextRunDateTime]")]
        public DateTime? NextRunDateTime { get; set; }

    }
}
