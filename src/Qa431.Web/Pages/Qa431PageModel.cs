using Qa431.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Qa431.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class Qa431PageModel : AbpPageModel
    {
        protected Qa431PageModel()
        {
            LocalizationResourceType = typeof(Qa431Resource);
        }
    }
}