using MyCleanArchitectureApp.Application;
using MyCleanArchitectureApp.Core;
using MyCleanArchitectureApp.Infrastructure;

namespace MyCleanArchitectureApp.Api
{
	/// <summary>
	/// Dependency Injection
	/// </summary>
	public static class DependencyInjection
	{
		/// <summary>
		/// Add Application Layer DI
		/// </summary>
		/// <param name="services"></param>
		/// <returns></returns>
		public static IServiceCollection AddAppDI(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddApplicationDI()
					.AddInfraDI()
					.AddCoreDI(configuration);
			return services;
		}
	}
}
