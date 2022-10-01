using RihalApp.Services.GetStudentsUseCaseService;

namespace RihalApp.Services.GetStudentByIdUseCaseService
{
    public interface IGetStudentByIdToEditUseCaseService
    {
        Task<StudentToEditDto> GetStudentByIdAsync(int studentId);
    }
}
