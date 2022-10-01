using RihalApp.Domain.Entities;


namespace RihalApp.DataAccess.DbDataSeeder
{
    internal sealed class StudentsTableData
    {
        public static readonly List<Student> StudentsData = new List<Student>()
        {
            new Student(){Id=1,Name=Faker.Name.FullName(),CountryId=1,ClassId=1,DateOfBirth= Faker.Identification.DateOfBirth()},
            new Student(){Id=2,Name=Faker.Name.FullName(),CountryId=2,ClassId=1, DateOfBirth= Faker.Identification.DateOfBirth()},
            new Student(){Id=3,Name=Faker.Name.FullName(),CountryId=3,ClassId=1, DateOfBirth= Faker.Identification.DateOfBirth()},
            new Student(){Id=4,Name=Faker.Name.FullName(),CountryId=3,ClassId=2, DateOfBirth= Faker.Identification.DateOfBirth()},
            new Student(){Id=5,Name=Faker.Name.FullName(),CountryId=3,ClassId=2, DateOfBirth= Faker.Identification.DateOfBirth()},
            new Student(){Id=6,Name=Faker.Name.FullName(),CountryId=1,ClassId=3, DateOfBirth= Faker.Identification.DateOfBirth()},
            new Student(){Id=7,Name=Faker.Name.FullName(),CountryId=1,ClassId=3, DateOfBirth= Faker.Identification.DateOfBirth()},
            new Student(){Id=8,Name=Faker.Name.FullName(),CountryId=2,ClassId=3, DateOfBirth= Faker.Identification.DateOfBirth()},
            new Student(){Id=9,Name=Faker.Name.FullName(),CountryId=1,ClassId=2, DateOfBirth= Faker.Identification.DateOfBirth()},
            new Student(){Id=10,Name=Faker.Name.FullName(),CountryId=2,ClassId=3, DateOfBirth= Faker.Identification.DateOfBirth()},
            new Student(){Id=11,Name=Faker.Name.FullName(),CountryId=1,ClassId=2, DateOfBirth= Faker.Identification.DateOfBirth()},
            new Student(){Id=12,Name=Faker.Name.FullName(),CountryId=2,ClassId=3, DateOfBirth= Faker.Identification.DateOfBirth()},
            new Student(){Id=13,Name=Faker.Name.FullName(),CountryId=4,ClassId=3, DateOfBirth= Faker.Identification.DateOfBirth()}

        };
    }
}
