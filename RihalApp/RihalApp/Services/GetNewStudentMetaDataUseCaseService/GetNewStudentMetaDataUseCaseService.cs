using RihalApp.Domain.Repositories;
using RihalApp.Services.GetNewStudentMetaDataUseCaseService;

namespace RihalApp.Services.GetNewStudentMetaDataUseCaseService
{
    public sealed class GetNewStudentMetaDataUseCaseService : IGetNewStudentMetaDataUseCaseService
    {
        private readonly IGetCountriesUseCaseRepository _getCountriesUseCaseRepository;
        private readonly IGetClassesUseCaseRepository _getClassesUseCaseRepository;

        public GetNewStudentMetaDataUseCaseService(IGetCountriesUseCaseRepository getCountriesUseCaseRepository, IGetClassesUseCaseRepository getClassesUseCaseRepository)
        {
            _getCountriesUseCaseRepository = getCountriesUseCaseRepository ?? throw new ArgumentNullException(nameof(getCountriesUseCaseRepository));
            _getClassesUseCaseRepository = getClassesUseCaseRepository ?? throw new ArgumentNullException(nameof(getClassesUseCaseRepository));
        }

        public async Task<NewStudentMetaData> GetNewStudentMetaDataAsync(CancellationToken cancellationToken)
        {
            var outout = new NewStudentMetaData();

            var Countries = await _getCountriesUseCaseRepository.GetCountriesAsync(cancellationToken);
            outout.Countries = Countries.Select(country => CountryOutputDto.Map(country)).ToList();

            var classes = await _getClassesUseCaseRepository.GetClassesAsync(cancellationToken);
            outout.Classes = classes.Select(c => ClassOutputDto.Map(c)).ToList();
          
            return outout;
        }
    }
}
