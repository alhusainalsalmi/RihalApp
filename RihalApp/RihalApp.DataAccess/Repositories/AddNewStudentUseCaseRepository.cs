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
    public sealed class AddNewStudentUseCaseRepository : IAddNewStudentUseCaseRepository
    {
        private readonly RihalAppDbContext _rihalAppDbContext;

        public AddNewStudentUseCaseRepository(RihalAppDbContext rihalAppDbContext)
        {
            _rihalAppDbContext = rihalAppDbContext ?? throw new ArgumentNullException(nameof(rihalAppDbContext));
        }
        public async Task<int> GetNextId()
        {
            return await Task.FromResult(_rihalAppDbContext.Students.Max(x => x.Id) + 1);
        }
        public async Task AddStudentAsync(Student student, CancellationToken cancellationToken)
        {
            try
            {
                _rihalAppDbContext.Students.Add(student);
                await _rihalAppDbContext.SaveChangesAsync(cancellationToken);
            }
            catch(Exception ex)
            {
                throw new Exception($"Error occured while adding new Student {typeof(AddNewStudentUseCaseRepository)}");
            }
                
        }
        public async Task<Country> GetCountryByIdAsync(int id)
        {
            var output = await _rihalAppDbContext.Countries.FindAsync(id);

            if (output == null)
                throw new Exception($"Country of id:{id} cannot be fine {typeof(AddNewStudentUseCaseRepository)}");

            return output;
        }
        public async Task<Class> GetClassByIdAsync(int id)
        {
            var output = await _rihalAppDbContext.Classes.FindAsync(id);

            if (output == null)
                throw new Exception($"Class of id:{id} cannot be fine {typeof(AddNewStudentUseCaseRepository)}");

            return output;
        }

     

      
    }
}
