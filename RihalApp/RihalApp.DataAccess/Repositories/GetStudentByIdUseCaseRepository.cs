using RihalApp.DataAccess.DbContext;
using RihalApp.Domain.Entities;
using RihalApp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RihalApp.DataAccess.Repositories
{
    public sealed class GetStudentByIdUseCaseRepository : IGetStudentByIdUseCaseRepository
    {
        private readonly RihalAppDbContext _rihalAppDbContext;

        public GetStudentByIdUseCaseRepository(RihalAppDbContext rihalAppDbContext)
        {
            _rihalAppDbContext = rihalAppDbContext ?? throw new ArgumentNullException(nameof(rihalAppDbContext));
        }
        public async Task<Student> GetStudentByIdAsync(int studentId)
        {
            var student = await _rihalAppDbContext.Students.FindAsync(studentId);

            if (student == null)
                throw new Exception($"student with Id:{studentId} is not exist");

            return student;
        }
    }
}
