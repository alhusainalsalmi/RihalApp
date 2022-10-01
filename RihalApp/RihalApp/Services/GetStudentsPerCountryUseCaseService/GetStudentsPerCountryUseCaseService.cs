using RihalApp.Domain.Repositories;

namespace RihalApp.Services.GetStudentsPerCountryUseCaseService
{
    public class GetStudentsPerCountryUseCaseService : IGetStudentsPerCountryUseCaseService
    {
        private readonly IGetStudentsPerCountryUseCaseRepository _getStudentsPerCountryUseCaseRepository;

        public GetStudentsPerCountryUseCaseService(IGetStudentsPerCountryUseCaseRepository getStudentsPerCountryUseCaseRepository)
        {
            _getStudentsPerCountryUseCaseRepository = getStudentsPerCountryUseCaseRepository ?? throw new ArgumentNullException(nameof(getStudentsPerCountryUseCaseRepository));
        }

        public async Task<List<StudentsPerCountryOutputDto>> GetStudentsPerCountryAsync(CancellationToken cancellationToken)
        {
            var studentPerCountryList = await _getStudentsPerCountryUseCaseRepository.GetStudentsPerCountryAsync(cancellationToken);

            return studentPerCountryList.Select(s => StudentsPerCountryOutputDto.Map(s)).ToList();
        }
    }
}
