using RihalApp.Services.GetNewStudentMetaDataUseCaseService;

namespace RihalApp.Services.GetNewStudentMetaDataUseCaseService
{
    public class NewStudentMetaData
    {
        public List<ClassOutputDto> Classes { get; set; } = new List<ClassOutputDto>();
        public List<CountryOutputDto> Countries { get; set; } = new List<CountryOutputDto>();

    }
}
