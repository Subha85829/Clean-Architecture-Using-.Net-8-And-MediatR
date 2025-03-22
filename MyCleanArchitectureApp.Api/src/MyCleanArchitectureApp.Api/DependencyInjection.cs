using MyCleanArchitectureApp.Application;
using MyCleanArchitectureApp.Infrastructure;

namespace MyCleanArchitectureApp.Api
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddAppDI(this IServiceCollection services)
		{
			services.AddApplicationDI()
					.AddInfraDI();
			return services;
		}
	}
}
