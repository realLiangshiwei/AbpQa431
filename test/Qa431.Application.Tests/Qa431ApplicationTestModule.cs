using Volo.Abp.Modularity;

namespace Qa431
{
    [DependsOn(
        typeof(Qa431ApplicationModule),
        typeof(Qa431DomainTestModule)
        )]
    public class Qa431ApplicationTestModule : AbpModule
    {

    }
}