using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Qa431.EntityFrameworkCore
{
    [DependsOn(
        typeof(Qa431EntityFrameworkCoreModule)
        )]
    public class Qa431EntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<Qa431MigrationsDbContext>();
        }
    }
}
