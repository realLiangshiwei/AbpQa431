using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Qa431
{
    public class Qa431WebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<Qa431WebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}