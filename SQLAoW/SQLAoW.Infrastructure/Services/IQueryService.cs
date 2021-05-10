using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SQLAoW.Infrastructure.Services
{
    public interface IQueryService
    {
        string ConnectionStringName { get; set; }

        Task<IEnumerable<T>> GetAll<T>() where T : class;
        Task<IEnumerable<T>> GetOne<T>(Expression<Func<T, bool>> expression) where T : class;
    }
}