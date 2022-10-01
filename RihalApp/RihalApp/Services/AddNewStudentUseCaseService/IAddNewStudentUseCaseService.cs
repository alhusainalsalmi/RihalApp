using RihalApp.FormModels;

namespace RihalApp.Services.AddNewStudentUseCaseService
{
    public interface IAddNewStudentUseCaseService
    {
        Task AddNewStudentAsync(NewStudent newStudent, CancellationToken cancellationToken);
    }
}
