using RihalApp.DataAccess.Repositories;
using RihalApp.Domain.Repositories;


namespace RihalApp.Registrations
{
    internal static class RepositoriesRegistration
    {
        public static void RihalRepositoriesRegistration(this IServiceCollection services)
        {
            services.AddScoped<IIsStudentsTableHasRecordsUseCaseRepository, IsStudentsTableHasRecordsUseCaseRepository>();
            services.AddScoped<IGetStudentsPerClassUseCaseRepository, GetStudentsPerClassUseCaseRepository>();
            services.AddScoped<IGetStudentsPerCountryUseCaseRepository, GetStudentsPerCountryUseCaseRepository>();
            services.AddScoped<IGetStudentsDateOfBirthUseCaseRepository, GetStudentsDateOfBirthUseCaseRepository>();
            services.AddScoped<IGetClassesUseCaseRepository, GetClassesUseCaseRepository>();
            services.AddScoped<IGetCountriesUseCaseRepository, GetCountriesUseCaseRepository>();
            services.AddScoped<IAddNewStudentUseCaseRepository, AddNewStudentUseCaseRepository>();
            services.AddScoped<IGetStudentsUseCaseRepository, GetStudentsUseCaseRepository>();
            services.AddScoped<IDeleteStudentUseCaseRepository, DeleteStudentUseCaseRepository>();
            services.AddScoped<IGetStudentByIdUseCaseRepository, GetStudentByIdUseCaseRepository>();
            services.AddScoped<IUpdateStudentUseCaseRepository, UpdateStudentUseCaseRepository>();       
        }
    }
}
