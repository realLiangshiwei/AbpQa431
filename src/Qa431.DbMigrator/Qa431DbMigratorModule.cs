using Qa431.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Qa431.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(Qa431EntityFrameworkCoreDbMigrationsModule),
        typeof(Qa431ApplicationContractsModule)
        )]
    public class Qa431DbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
