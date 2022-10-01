namespace RihalApp.Services.GetStudentsPerClassUseCaseService
{
    public interface IGetStudentsPerClassUseCaseService
    {
        Task<List<StudentsPerClassOutputDto>> GetStudentsPerClassAsync(CancellationToken cancellationToken);
    }
}
