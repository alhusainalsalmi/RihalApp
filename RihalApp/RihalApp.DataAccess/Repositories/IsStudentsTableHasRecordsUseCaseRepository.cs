using Microsoft.EntityFrameworkCore;
using RihalApp.DataAccess.DbContext;
using RihalApp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RihalApp.DataAccess.Repositories
{
    public sealed class IsStudentsTableHasRecordsUseCaseRepository : IIsStudentsTableHasRecordsUseCaseRepository
    {
        private readonly RihalAppDbContext _rihalAppDbContext;

        public IsStudentsTableHasRecordsUseCaseRepository(RihalAppDbContext rihalAppDbContext)
        {
            _rihalAppDbContext = rihalAppDbContext ?? throw new ArgumentNullException(nameof(rihalAppDbContext));
        }

        public Task<bool> IsStudentsTableHasRecordsAsync(CancellationToken cancellationToken)
        {
            return _rihalAppDbContext.Students.AsNoTracking().AnyAsync(cancellationToken);
        }
    }
}
