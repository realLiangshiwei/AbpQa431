using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Qa431.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(Qa431HttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class Qa431ConsoleApiClientModule : AbpModule
    {
        
    }
}
