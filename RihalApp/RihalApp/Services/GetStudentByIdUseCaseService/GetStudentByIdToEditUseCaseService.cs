using RihalApp.Domain.Repositories;
using RihalApp.Services.GetStudentsUseCaseService;

namespace RihalApp.Services.GetStudentByIdUseCaseService
{
    public sealed class GetStudentByIdToEditUseCaseService : IGetStudentByIdToEditUseCaseService
    {
        private readonly IGetStudentByIdUseCaseRepository _getStudentByIdUseCaseRepository;

        public GetStudentByIdToEditUseCaseService(IGetStudentByIdUseCaseRepository getStudentByIdUseCaseRepository)
        {
            _getStudentByIdUseCaseRepository = getStudentByIdUseCaseRepository ?? throw new ArgumentNullException(nameof(getStudentByIdUseCaseRepository));
        }

        public async Task<StudentToEditDto> GetStudentByIdAsync(int studentId)
        {
            var student = await _getStudentByIdUseCaseRepository.GetStudentByIdAsync(studentId);

            return StudentToEditDto.Map(student);
        }
    }
}
