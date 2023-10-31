using EmployeesTest.Contracts;
using EmployeesTest.Data;
using EmployeesTest.Services;

namespace EmployeesTest
{
    public static class ServiceExtensions
    {
        public static void ConfigureDatabase(this IServiceCollection services)
        {
            services.AddSingleton<EmployeesDatabase>();
        }

        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddTransient<IEmployeeService, EmployeeService>();
        }
    }
}
