using Radzen;
using RihalApp.Services.IsStudentsTableHasRecordsUseCase;
using RihalApp.Notifier;
using RihalApp.Services.GetStudentsPerClassUseCaseService;
using RihalApp.Services.GetStudentsPerCountryUseCaseService;
using RihalApp.Services.GetStudentsAverageAgeUseCaseService;
using MudBlazor.Services;
using RihalApp.Services.GetNewStudentMetaDataUseCaseService;
using RihalApp.Services.AddNewStudentUseCaseService;
using RihalApp.Services.GetStudentsUseCaseService;
using RihalApp.Services.GetStudentByIdUseCaseService;
using RihalApp.Services.UpdateStudentUseCaseService;

namespace RihalApp.Registrations
{
    internal static class ServicesRegistration
    {
        public static void RihalServicesRegistration(this IServiceCollection services)
        {
            services.AddSingleton<NotificationService>();
            services.AddSingleton<AppNotifier>();
            services.AddMudServices();
            services.AddScoped<IIsStudentsTableHasRecordsUseCaseService, IsStudentsTableHasRecordsUseCaseService>();
            services.AddScoped<IGetStudentsPerClassUseCaseService, GetStudentsPerClassUseCaseService>();
            services.AddScoped<IGetStudentsPerCountryUseCaseService, GetStudentsPerCountryUseCaseService>();
            services.AddScoped<IGetStudentsAverageAgeUseCaseService, GetStudentsAverageAgeUseCaseService>();
            services.AddScoped<IGetNewStudentMetaDataUseCaseService, GetNewStudentMetaDataUseCaseService>();
            services.AddScoped<IAddNewStudentUseCaseService, AddNewStudentUseCaseService>();
            services.AddScoped<IGetStudentsUseCaseService, GetStudentsUseCaseService>();
            services.AddScoped<IGetStudentByIdToEditUseCaseService, GetStudentByIdToEditUseCaseService>();
            services.AddScoped<IUpdateStudentUseCaseService, UpdateStudentUseCaseService>();

            
        }
    }
}
