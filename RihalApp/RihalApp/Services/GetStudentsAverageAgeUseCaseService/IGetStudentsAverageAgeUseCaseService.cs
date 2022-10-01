namespace RihalApp.Services.GetStudentsAverageAgeUseCaseService
{
    public interface IGetStudentsAverageAgeUseCaseService
    {
        Task<int> GetStudentsAverageAgeUseCaseAsync(CancellationToken cancellationToken);
    }
}
