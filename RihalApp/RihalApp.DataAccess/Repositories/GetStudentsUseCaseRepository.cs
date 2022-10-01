using Microsoft.EntityFrameworkCore;
using RihalApp.DataAccess.DbContext;
using RihalApp.Domain.Entities;
using RihalApp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RihalApp.DataAccess.Repositories
{
    public class GetStudentsUseCaseRepository : IGetStudentsUseCaseRepository
    {
        private readonly RihalAppDbContext _rihalAppDbContext;

        public GetStudentsUseCaseRepository(RihalAppDbContext rihalAppDbContext)
        {
            _rihalAppDbContext = rihalAppDbContext ?? throw new ArgumentNullException(nameof(rihalAppDbContext));
        }
        public async Task<List<Student>> GetStudentsAsync(CancellationToken cancellationToken)
        {
            return await _rihalAppDbContext.Students
                .Include(c => c.Class)
                .Include(c => c.Country)
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }
    }
}
