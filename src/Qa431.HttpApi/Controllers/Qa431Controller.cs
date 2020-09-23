using Qa431.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Qa431.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class Qa431Controller : AbpController
    {
        protected Qa431Controller()
        {
            LocalizationResource = typeof(Qa431Resource);
        }
    }
}