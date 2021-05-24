using System.Data;

namespace SQLAoW.Infrastructure
{
    public interface IStorage
    {
        IDbConnection CreateConnection();
    }
}