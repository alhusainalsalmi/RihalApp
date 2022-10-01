using RihalApp.Domain.Entities;
using RihalApp.Domain.Repositories;
using RihalApp.Services.GetStudentByIdUseCaseService;

namespace RihalApp.Services.UpdateStudentUseCaseService
{
    public sealed class UpdateStudentUseCaseService : IUpdateStudentUseCaseService
    {
        private readonly IUpdateStudentUseCaseRepository _updateStudentUseCaseRepository;

        public UpdateStudentUseCaseService(IUpdateStudentUseCaseRepository updateStudentUseCaseRepository)
        {
            _updateStudentUseCaseRepository = updateStudentUseCaseRepository ?? throw new ArgumentNullException(nameof(updateStudentUseCaseRepository));
        }

        public async Task UpdateStudentAsync(StudentToEditDto studentToUpdate, CancellationToken cancellationToken)
        {
            var student = new Student()
            {
                Id = studentToUpdate.Id,
                Name = studentToUpdate.Name,
                ClassId = studentToUpdate.ClassId,
                CountryId = studentToUpdate.CountryId,
                DateOfBirth = studentToUpdate.DateOfBirth,

            };

            await _updateStudentUseCaseRepository.UpdateStudentAsync(student, cancellationToken);

        }
    }
}
