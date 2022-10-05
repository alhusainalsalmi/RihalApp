using RihalApp.Domain.Entities;
using RihalApp.Domain.Repositories;
using RihalApp.FormModels;

namespace RihalApp.Services.AddNewStudentUseCaseService
{
    public sealed class AddNewStudentUseCaseService : IAddNewStudentUseCaseService
    {
        private readonly IAddNewStudentUseCaseRepository _addNewStudentUseCaseRepository;

        public AddNewStudentUseCaseService(IAddNewStudentUseCaseRepository addNewStudentUseCaseRepository)
        {
            _addNewStudentUseCaseRepository = addNewStudentUseCaseRepository ?? throw new ArgumentNullException(nameof(addNewStudentUseCaseRepository));
        }

        public async Task AddNewStudentAsync(NewStudent newStudent, CancellationToken cancellationToken)
        {
            
            var newId = await _addNewStudentUseCaseRepository.GetNextId();
          

            var student = new Student()
            {
                Id = newId,
                Name = newStudent.Name,
                DateOfBirth = newStudent.DateOfBirth,              
                CountryId = newStudent.CountryId,
                ClassId = newStudent.ClassId
            };

             await _addNewStudentUseCaseRepository.AddStudentAsync(student, cancellationToken);

        }
    }
}
