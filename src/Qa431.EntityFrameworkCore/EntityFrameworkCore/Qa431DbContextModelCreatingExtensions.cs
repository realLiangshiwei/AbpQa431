using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Qa431.EntityFrameworkCore
{
    public static class Qa431DbContextModelCreatingExtensions
    {
        public static void ConfigureQa431(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(Qa431Consts.DbTablePrefix + "YourEntities", Qa431Consts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}