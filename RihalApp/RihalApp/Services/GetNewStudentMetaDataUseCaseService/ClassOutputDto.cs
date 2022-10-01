using RihalApp.Domain.Entities;

namespace RihalApp.Services.GetNewStudentMetaDataUseCaseService
{
    public class ClassOutputDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static ClassOutputDto Map(Class classInfo)
        {
            return new ClassOutputDto
            {
                Id = classInfo.Id,
                Name = classInfo.Name
            };
        }
    }
}
