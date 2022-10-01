using Microsoft.Extensions.DependencyInjection;
using RihalApp.DataAccess.DbDataSeeder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RihalApp.DataAccess.DbContext
{
    public sealed class RihalAppDatabaseInitializor
    {
        public static void InitializeDatabase(IServiceScope scope)
        {
            var dataContext = scope.ServiceProvider.GetRequiredService<RihalAppDbContext>();
            dataContext.Database.EnsureCreated();
            RihalAppDbSeeder.SeedRihalDb(dataContext);
        }
    }
}
