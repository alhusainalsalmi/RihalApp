namespace RihalApp.Services.GetStudentsUseCaseService
{
    public interface IGetStudentsUseCaseService
    {
        Task<List<StudentOutputDto>> GetStudentsAsync(CancellationToken cancellationToken);
    }
}
