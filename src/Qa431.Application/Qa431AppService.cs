using System;
using System.Collections.Generic;
using System.Text;
using Qa431.Localization;
using Volo.Abp.Application.Services;

namespace Qa431
{
    /* Inherit your application services from this class.
     */
    public abstract class Qa431AppService : ApplicationService
    {
        protected Qa431AppService()
        {
            LocalizationResource = typeof(Qa431Resource);
        }
    }
}
