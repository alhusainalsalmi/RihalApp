using RihalApp.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RihalApp.Domain.Repositories
{
    public interface IGetStudentsPerClassUseCaseRepository
    {
        Task<List<StudentsPerClassValueObject>> GetStudentsPerClassAsync(CancellationToken cancellationToken);
    }
}
