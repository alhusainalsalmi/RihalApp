using RihalApp.Services.GetStudentByIdUseCaseService;

namespace RihalApp.Services.UpdateStudentUseCaseService
{
    public interface IUpdateStudentUseCaseService
    {
        Task UpdateStudentAsync(StudentToEditDto student, CancellationToken cancellationToken);
    }
}
