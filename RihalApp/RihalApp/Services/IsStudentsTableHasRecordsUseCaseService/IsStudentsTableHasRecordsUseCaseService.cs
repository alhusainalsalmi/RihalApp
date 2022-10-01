using RihalApp.Domain.Repositories;

namespace RihalApp.Services.IsStudentsTableHasRecordsUseCase
{
    public class IsStudentsTableHasRecordsUseCaseService : IIsStudentsTableHasRecordsUseCaseService
    {
        private readonly IIsStudentsTableHasRecordsUseCaseRepository _isStudentsTableHasRecordsUseCaseRepository;
        public IsStudentsTableHasRecordsUseCaseService(IIsStudentsTableHasRecordsUseCaseRepository isStudentsTableHasRecordsUseCaseRepository)
        {
            _isStudentsTableHasRecordsUseCaseRepository = isStudentsTableHasRecordsUseCaseRepository ?? throw new ArgumentNullException(nameof(isStudentsTableHasRecordsUseCaseRepository));
        }

        public async Task<bool> IsStudentsTableHasRecordsUseCaseAsync(CancellationToken cancellationToken)
        {
            return await _isStudentsTableHasRecordsUseCaseRepository.IsStudentsTableHasRecordsAsync(cancellationToken);
        }
    }
}
