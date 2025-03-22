using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyCleanArchitectureApp.Core.Interfaces;
using MyCleanArchitectureApp.Infrastructure.Data;
using MyCleanArchitectureApp.Infrastructure.Repositories;

namespace MyCleanArchitectureApp.Infrastructure
{
	/// <summary>
	/// Dependency Injection
	/// </summary>
	public static class DependencyInjection
	{
		/// <summary>
		/// Add Infra DI
		/// </summary>
		/// <param name="services"></param>
		/// <returns></returns>
		public static IServiceCollection AddInfraDI(this IServiceCollection services)
		{
			services.AddDbContext<AppDbContext>(options =>
			{
				options.UseSqlServer("Server = LAPTOP-4RAD5B8V\\SQLEXPRESS01; Database = TestCleanArchAPIDB; Trusted_Connection = True; TrustServerCertificate = True; MultipleActiveResultSets=true");
			});

			// Registering the repositories
			services.AddScoped<IEmployeeRepository, EmployeeRepository>();

			return services;
		}
	}
}
