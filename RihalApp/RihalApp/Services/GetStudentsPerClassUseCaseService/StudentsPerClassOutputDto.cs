using RihalApp.Domain.ValueObjects;

namespace RihalApp.Services.GetStudentsPerClassUseCaseService
{
    public sealed class StudentsPerClassOutputDto
    {
        public string ClassName { get; set; }
        public int NumberOfStudents { get; set; }

        public static StudentsPerClassOutputDto Map(StudentsPerClassValueObject studentsPerClass)
        {
            return new StudentsPerClassOutputDto
            {
                ClassName = studentsPerClass.ClassName,
                NumberOfStudents = studentsPerClass.NumberOfStudents
            };
        }
    }
}
