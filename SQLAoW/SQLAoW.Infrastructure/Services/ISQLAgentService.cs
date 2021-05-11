using System.Threading.Tasks;

namespace SQLAoW.Infrastructure.Services
{
    public interface ISQLAgentService
    {
        IStorage Storage { get; set; }

        Task<bool> RunJob(string JobId);
    }
}