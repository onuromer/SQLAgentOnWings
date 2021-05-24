using System.Threading.Tasks;

namespace SQLAoW.Infrastructure.Services
{
    public interface _ISQLAgentService
    {
        IStorage Storage { get; set; }

        Task<bool> StartJob(string JobId);
    }
}