using Qa431.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Qa431
{
    [DependsOn(
        typeof(Qa431EntityFrameworkCoreTestModule)
        )]
    public class Qa431DomainTestModule : AbpModule
    {

    }
}