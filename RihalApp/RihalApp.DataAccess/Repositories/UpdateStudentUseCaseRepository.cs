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
    public sealed class UpdateStudentUseCaseRepository : IUpdateStudentUseCaseRepository
    {
        private readonly RihalAppDbContext _rihalAppDbContext;

        public UpdateStudentUseCaseRepository(RihalAppDbContext rihalAppDbContext)
        {
            _rihalAppDbContext = rihalAppDbContext ?? throw new ArgumentNullException(nameof(rihalAppDbContext));
        }
        public async Task UpdateStudentAsync(Student studentToUpdate, CancellationToken cancellationToken)
        {
            var student = await _rihalAppDbContext.Students.FindAsync(studentToUpdate.Id);

            if (student == null)
                throw new Exception($" student with id: {studentToUpdate.Id} is not exist");

            studentToUpdate.CreationDate = student.CreationDate;

            _rihalAppDbContext.Entry(student).CurrentValues.SetValues(studentToUpdate);
            await _rihalAppDbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
