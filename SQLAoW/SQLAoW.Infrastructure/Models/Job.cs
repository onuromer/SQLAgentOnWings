using RepoDb.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SQLAoW.Infrastructure.Models
{
    [Table("sysjobs")]
    public class Job
    {
        [Key]
        [Map("[job_id]")]
        public string JobId { get; set; }
        [Map("[name]")]
        public string Name { get; set; }
        [Map("[enabled]")]
        public bool Enabled { get; set; }
        [Map("[description]")]
        public string Description { get; set; }
        [Map("[date_created]")]
        public DateTime DateCreated { get; set; }
        [Map("[date_modified]")]
        public DateTime DateModified { get; set; }
    }
}
