using RihalApp.Domain.Entities;


namespace RihalApp.Domain.Repositories
{
    public  interface IGetStudentByIdUseCaseRepository
    {
        Task<Student> GetStudentByIdAsync(int studentId); 
    }
}
