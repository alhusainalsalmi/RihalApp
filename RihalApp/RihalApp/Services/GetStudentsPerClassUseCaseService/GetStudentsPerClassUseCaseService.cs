using RihalApp.Domain.Repositories;

namespace RihalApp.Services.GetStudentsPerClassUseCaseService
{
    public class GetStudentsPerClassUseCaseService : IGetStudentsPerClassUseCaseService
    {
        private readonly IGetStudentsPerClassUseCaseRepository _getStudentsPerClassUseCaseRepository;

        public GetStudentsPerClassUseCaseService(IGetStudentsPerClassUseCaseRepository getStudentsPerClassUseCaseRepository)
        {
            _getStudentsPerClassUseCaseRepository = getStudentsPerClassUseCaseRepository;
        }

        public async Task<List<StudentsPerClassOutputDto>> GetStudentsPerClassAsync(CancellationToken cancellationToken)
        {
          var studentPerClassList = await  _getStudentsPerClassUseCaseRepository.GetStudentsPerClassAsync(cancellationToken);

            return studentPerClassList.Select(s => StudentsPerClassOutputDto.Map(s)).ToList();
        }
    }
}
