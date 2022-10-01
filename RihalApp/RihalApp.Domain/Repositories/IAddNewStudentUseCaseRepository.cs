using RihalApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RihalApp.Domain.Repositories
{
    public interface IAddNewStudentUseCaseRepository
    {
        Task<int> GetNextId();
        Task AddStudentAsync(Student student, CancellationToken cancellationToken);
        Task<Country> GetCountryByIdAsync(int id);
        Task<Class> GetClassByIdAsync(int id);
    }
}
