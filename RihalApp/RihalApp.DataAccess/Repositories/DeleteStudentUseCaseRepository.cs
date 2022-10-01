using RihalApp.DataAccess.DbContext;
using RihalApp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RihalApp.DataAccess.Repositories
{
    public sealed class DeleteStudentUseCaseRepository : IDeleteStudentUseCaseRepository
    {
        private readonly RihalAppDbContext _rihalAppDbContext;

        public DeleteStudentUseCaseRepository(RihalAppDbContext rihalAppDbContext)
        {
            _rihalAppDbContext = rihalAppDbContext ?? throw new ArgumentNullException(nameof(rihalAppDbContext));
        }
        public async Task DeleteStudentByIdAsync(int studentId, CancellationToken cancellationToken)
        {
            var student = await _rihalAppDbContext.Students.FindAsync(studentId);

            if (student == null)
                throw new Exception($"student with Id:{studentId} is not exist");

             _rihalAppDbContext.Remove(student);
            await _rihalAppDbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
