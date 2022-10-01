using RihalApp.Domain.Repositories;

namespace RihalApp.Services.GetStudentsAverageAgeUseCaseService
{
    public class GetStudentsAverageAgeUseCaseService : IGetStudentsAverageAgeUseCaseService
    {
        private readonly IGetStudentsDateOfBirthUseCaseRepository _getStudentsDateOfBirthUseCaseRepository;

        public GetStudentsAverageAgeUseCaseService(IGetStudentsDateOfBirthUseCaseRepository getStudentsDateOfBirthUseCaseRepository)
        {
            _getStudentsDateOfBirthUseCaseRepository = getStudentsDateOfBirthUseCaseRepository ?? throw new ArgumentNullException(nameof(getStudentsDateOfBirthUseCaseRepository));
        }

        public async Task<int> GetStudentsAverageAgeUseCaseAsync(CancellationToken cancellationToken)
        {
            var StudentsDateOfBirthList = await _getStudentsDateOfBirthUseCaseRepository.GetStudentsDateOfBirthAsync(cancellationToken);

            return CalculateStudentsAverageAge(StudentsDateOfBirthList);
        }
        private int CalculateStudentsAverageAge(List<DateTime> studentsDateOfBirth)
        {
            var today = DateTime.Today;
            var studentsAverageAge = 0;

            foreach (var studentDateOfBirth in studentsDateOfBirth)
            {
                var studentAge = today.Year - studentDateOfBirth.Year;

                // in case student was porn in a leap year
                if (studentDateOfBirth.Date > today.AddYears(-studentAge))
                    studentAge--;

                studentsAverageAge += studentAge;
            }

            return studentsAverageAge / studentsDateOfBirth.Count();
        }
    }
}
