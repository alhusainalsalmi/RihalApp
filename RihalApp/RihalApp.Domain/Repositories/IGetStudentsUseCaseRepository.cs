using RihalApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RihalApp.Domain.Repositories
{
    public interface IGetStudentsUseCaseRepository
    {
        Task<List<Student>> GetStudentsAsync(CancellationToken cancellationToken);
    }
}
