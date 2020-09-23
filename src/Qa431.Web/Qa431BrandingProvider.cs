using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Qa431.Web
{
    [Dependency(ReplaceServices = true)]
    public class Qa431BrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Qa431";
    }
}
