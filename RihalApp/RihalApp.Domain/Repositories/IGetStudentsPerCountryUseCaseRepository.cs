using RihalApp.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RihalApp.Domain.Repositories
{
    public  interface IGetStudentsPerCountryUseCaseRepository
    {
        Task<List<StudentsPerCountryValueObject>> GetStudentsPerCountryAsync(CancellationToken cancellationToken);

    }
}
