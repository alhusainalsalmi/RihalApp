using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RihalApp.Domain.Repositories
{
    public interface IIsStudentsTableHasRecordsUseCaseRepository
    {
        Task<bool> IsStudentsTableHasRecordsAsync(CancellationToken cancellationToken);
    }
}
