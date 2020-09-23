using System.Threading.Tasks;

namespace Qa431.Data
{
    public interface IQa431DbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
