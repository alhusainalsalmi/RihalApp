using RihalApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RihalApp.DataAccess.DbDataSeeder
{
    internal sealed class CountriesTableData
    {
        public static readonly List<Country> CountriesData = new List<Country>()
        {
            new Country(){Id=1, Name=Faker.Country.Name()},
            new Country(){Id=2, Name=Faker.Country.Name()},
            new Country(){Id=3,Name=Faker.Country.Name()},
             new Country(){Id=4,Name="Other"}
        };
    }
}
