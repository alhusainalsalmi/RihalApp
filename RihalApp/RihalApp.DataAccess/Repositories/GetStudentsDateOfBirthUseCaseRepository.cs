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
    public sealed class GetStudentsDateOfBirthUseCaseRepository : IGetStudentsDateOfBirthUseCaseRepository
    {
        private readonly RihalAppDbContext _rihalAppDbContext;

        public GetStudentsDateOfBirthUseCaseRepository(RihalAppDbContext rihalAppDbContext)
        {
            _rihalAppDbContext = rihalAppDbContext ?? throw new ArgumentNullException(nameof(rihalAppDbContext));
        }
        public async Task<List<DateTime>> GetStudentsDateOfBirthAsync(CancellationToken cancellationToken)
        {
            var output = await _rihalAppDbContext.Students.AsNoTracking()
                    .Select(student => student.DateOfBirth).ToListAsync(cancellationToken);

            if (output == null)
                throw new Exception($"error in fetching studentsDateOfBirth {typeof(GetStudentsDateOfBirthUseCaseRepository)} ");

            return output;
        }
    }
}
