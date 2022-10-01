using RihalApp.Domain.Entities;


namespace RihalApp.Domain.Repositories
{
    public interface IGetClassesUseCaseRepository
    {
        Task<List<Class>> GetClassesAsync(CancellationToken cancellationToken);
    }
}
