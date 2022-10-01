using Microsoft.EntityFrameworkCore;
using RihalApp.DataAccess.DbContext;
using RihalApp.Domain.Repositories;
using RihalApp.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RihalApp.DataAccess.Repositories
{
    public sealed class GetStudentsPerCountryUseCaseRepository : IGetStudentsPerCountryUseCaseRepository
    {

        private readonly RihalAppDbContext _rihalAppDbContext;

        public GetStudentsPerCountryUseCaseRepository(RihalAppDbContext rihalAppDbContext)
        {
            _rihalAppDbContext = rihalAppDbContext ?? throw new ArgumentNullException(nameof(rihalAppDbContext));
        }

        public async Task<List<StudentsPerCountryValueObject>> GetStudentsPerCountryAsync(CancellationToken cancellationToken)
        {
            var output = await _rihalAppDbContext.Students
                .Include(st => st.Country)
                .GroupBy(st => st.CountryId)
                .Select(st => new StudentsPerCountryValueObject { CountryName = st.Select(c => c.Country.Name).First(), NumberOfStudents = st.Count() })
                .AsNoTracking()
                .ToListAsync(cancellationToken);

            if (output == null)
                throw new Exception($"error in fetching CountStudentsPerCountry {typeof(GetStudentsPerCountryUseCaseRepository)}");

            return output;
        }
    }
}
