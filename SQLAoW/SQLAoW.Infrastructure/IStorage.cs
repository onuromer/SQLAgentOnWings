using System.Data;

namespace SQLAoW.Infrastructure
{
    public interface IStorage
    {
        string ConnectionStringName { get; set; }
        IDbConnection Connection { get; set; }

        void Dispose();
    }
}