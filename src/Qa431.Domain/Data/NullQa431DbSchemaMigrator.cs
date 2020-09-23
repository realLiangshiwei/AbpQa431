using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Qa431.Data
{
    /* This is used if database provider does't define
     * IQa431DbSchemaMigrator implementation.
     */
    public class NullQa431DbSchemaMigrator : IQa431DbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}