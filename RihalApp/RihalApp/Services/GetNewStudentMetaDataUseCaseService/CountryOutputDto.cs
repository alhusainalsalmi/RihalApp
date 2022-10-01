using RihalApp.Domain.Entities;

namespace RihalApp.Services.GetNewStudentMetaDataUseCaseService
{
    public class CountryOutputDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static CountryOutputDto Map(Country country)
        {
            return new CountryOutputDto
            {
                Id = country.Id,
                Name = country.Name
            };
        }
    }
}
