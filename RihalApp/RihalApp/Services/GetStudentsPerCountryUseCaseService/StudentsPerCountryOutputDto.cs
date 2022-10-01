using RihalApp.Domain.ValueObjects;

namespace RihalApp.Services.GetStudentsPerCountryUseCaseService
{
    public sealed class StudentsPerCountryOutputDto
    {
        public string CountryName { get; set; }
        public int NumberOfStudents { get; set; }

        public static StudentsPerCountryOutputDto Map(StudentsPerCountryValueObject studentsPerClass)
        {
            return new StudentsPerCountryOutputDto
            {
                CountryName = studentsPerClass.CountryName,
                NumberOfStudents = studentsPerClass.NumberOfStudents
            };
        }
    }
}
