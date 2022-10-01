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
    public sealed class GetClassesUseCaseRepository : IGetClassesUseCaseRepository
    {
        private readonly RihalAppDbContext _rihalAppDbContext;

        public GetClassesUseCaseRepository(RihalAppDbContext rihalAppDbContext)
        {
            _rihalAppDbContext = rihalAppDbContext ?? throw new ArgumentNullException(nameof(rihalAppDbContext));
        }
        public async Task<List<Class>> GetClassesAsync(CancellationToken cancellationToken)
        {
            var output = await _rihalAppDbContext.Classes.AsNoTracking().ToListAsync(cancellationToken);

            if (output == null)
                throw new Exception($"error in fetching classes {typeof(GetClassesUseCaseRepository)} ");

            return output;
        }
    }
}
