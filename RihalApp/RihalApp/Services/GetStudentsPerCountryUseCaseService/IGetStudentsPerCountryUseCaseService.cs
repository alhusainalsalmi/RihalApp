namespace RihalApp.Services.GetStudentsPerCountryUseCaseService
{
    public interface IGetStudentsPerCountryUseCaseService
    {
        Task<List<StudentsPerCountryOutputDto>> GetStudentsPerCountryAsync(CancellationToken cancellationToken);
    }
}
