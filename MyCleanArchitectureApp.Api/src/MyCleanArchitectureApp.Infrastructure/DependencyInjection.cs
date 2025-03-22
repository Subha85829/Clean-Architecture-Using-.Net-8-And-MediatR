using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MyCleanArchitectureApp.Core.Interfaces;
using MyCleanArchitectureApp.Core.Options;
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
			services.AddDbContext<AppDbContext>((provider, options) =>
			{
				options.UseSqlServer(provider.GetRequiredService<IOptionsSnapshot<ConnectionStringOptions>>().Value.DefaultConnection);
			});

			// Registering the repositories
			services.AddScoped<IEmployeeRepository, EmployeeRepository>();

			return services;
		}
	}
}
