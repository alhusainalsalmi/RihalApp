using RihalApp.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace RihalApp.Services.GetStudentByIdUseCaseService
{
    public sealed class StudentToEditDto
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please Select Country")]
        public int ClassId { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please Select Country")]
        public int CountryId { get; set; }
        public DateTime DateOfBirth { get; set; }

        public static StudentToEditDto Map(Student student)
        {
            return new StudentToEditDto
            {
                Id = student.Id,
                Name = student.Name,
                DateOfBirth = student.DateOfBirth,
                CountryId = student.Country.Id,
                ClassId = student.Class.Id
            };
        }
    }
}
