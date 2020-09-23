using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Qa431.Data;
using Volo.Abp.DependencyInjection;

namespace Qa431.EntityFrameworkCore
{
    public class EntityFrameworkCoreQa431DbSchemaMigrator
        : IQa431DbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreQa431DbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the Qa431MigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<Qa431MigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}