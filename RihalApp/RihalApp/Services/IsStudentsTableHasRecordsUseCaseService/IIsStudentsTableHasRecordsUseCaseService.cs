namespace RihalApp.Services.IsStudentsTableHasRecordsUseCase
{
    public interface IIsStudentsTableHasRecordsUseCaseService
    {
        Task<bool> IsStudentsTableHasRecordsUseCaseAsync(CancellationToken cancellationToken);
    }
}
