using RihalApp.Domain.Repositories;

namespace RihalApp.Services.GetStudentsUseCaseService
{
    public sealed class GetStudentsUseCaseService : IGetStudentsUseCaseService
    {
        private readonly IGetStudentsUseCaseRepository _getStudentsUseCaseRepository;

        public GetStudentsUseCaseService(IGetStudentsUseCaseRepository getStudentsUseCaseRepository)
        {
            _getStudentsUseCaseRepository = getStudentsUseCaseRepository ?? throw new ArgumentNullException(nameof(getStudentsUseCaseRepository));
        }

        public async Task<List<StudentOutputDto>> GetStudentsAsync(CancellationToken cancellationToken)
        {
            var students = await _getStudentsUseCaseRepository.GetStudentsAsync(cancellationToken);

            return students.Select(student => StudentOutputDto.Map(student)).ToList();
        }
    }
}
