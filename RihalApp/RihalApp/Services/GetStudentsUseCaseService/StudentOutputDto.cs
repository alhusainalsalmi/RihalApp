using RihalApp.Domain.Entities;

namespace RihalApp.Services.GetStudentsUseCaseService
{
    public class StudentOutputDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Country { get; set; }
        public DateTime DateOfBirth { get; set; }

        public static StudentOutputDto Map(Student student)
        {
            return new StudentOutputDto
            {
                Id = student.Id,
                Name = student.Name,
                DateOfBirth = student.DateOfBirth,
                Country = student.Country.Name,
                Class = student.Class.Name
            };
        }
    }
}
