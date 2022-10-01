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
    public sealed class GetStudentsPerClassUseCaseRepository : IGetStudentsPerClassUseCaseRepository
    {

        private readonly RihalAppDbContext _rihalAppDbContext;

        public GetStudentsPerClassUseCaseRepository(RihalAppDbContext rihalAppDbContext)
        {
            _rihalAppDbContext = rihalAppDbContext ?? throw new ArgumentNullException(nameof(rihalAppDbContext));
        }

        public async Task<List<StudentsPerClassValueObject>> GetStudentsPerClassAsync(CancellationToken cancellationToken)
        {
            var output = await _rihalAppDbContext.Students
          .Include(st => st.Class)
          .GroupBy(st => st.ClassId)
          .Select(st => new StudentsPerClassValueObject { ClassName = st.Select(c => c.Class.Name).First(), NumberOfStudents = st.Count() })
          .AsNoTracking()
          .ToListAsync(cancellationToken);

            if (output == null)
                throw new Exception($"error in fetching CountStudentsPerClass {typeof(GetStudentsPerClassUseCaseRepository)} ");

            return output;
        }
    }
}
