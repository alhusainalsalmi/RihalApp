using RihalApp.DataAccess.DbContext;


namespace RihalApp.DataAccess.DbDataSeeder
{
    internal sealed class RihalAppDbSeeder
    {
        public  static void SeedRihalDb(RihalAppDbContext rihalDbContext)
        {
            if (!rihalDbContext.Students.Any())
            {

                rihalDbContext.Classes.AddRange(ClassesTableData.ClassesData);
                rihalDbContext.Countries.AddRange(CountriesTableData.CountriesData);
                rihalDbContext.Students.AddRange(StudentsTableData.StudentsData);

                rihalDbContext.SaveChangesAsync();
            }
        }
    }
}
