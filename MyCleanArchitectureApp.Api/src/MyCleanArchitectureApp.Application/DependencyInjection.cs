using Microsoft.Extensions.DependencyInjection;

namespace MyCleanArchitectureApp.Application
{
	/// <summary>
	/// Dependency Injection
	/// </summary>
	public static class DependencyInjection
    {
		/// <summary>
		/// Add Application DI
		/// </summary>
		/// <param name="services"></param>
		/// <returns></returns>
		public static IServiceCollection AddApplicationDI(this IServiceCollection services)
        {
			services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly));
			return services;
        }
    }
}
