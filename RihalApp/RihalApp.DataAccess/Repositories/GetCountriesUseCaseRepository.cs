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
    public sealed class GetCountriesUseCaseRepository : IGetCountriesUseCaseRepository
    {
        private readonly RihalAppDbContext _rihalAppDbContext;

        public GetCountriesUseCaseRepository(RihalAppDbContext rihalAppDbContext)
        {
            _rihalAppDbContext = rihalAppDbContext ?? throw new ArgumentNullException(nameof(rihalAppDbContext));
        }
        public async Task<List<Country>> GetCountriesAsync(CancellationToken cancellationToken)
        {
            var output = await _rihalAppDbContext.Countries.AsNoTracking().ToListAsync(cancellationToken);

            if (output == null)
                throw new Exception($"error in fetching Countries {typeof(GetCountriesUseCaseRepository)} ");

            return output;
        }
    }
}
