using RihalApp.Services.GetNewStudentMetaDataUseCaseService;

namespace RihalApp.Services.GetNewStudentMetaDataUseCaseService
{
    public interface IGetNewStudentMetaDataUseCaseService
    {
        Task<NewStudentMetaData> GetNewStudentMetaDataAsync(CancellationToken cancellationToken);
    }
}
