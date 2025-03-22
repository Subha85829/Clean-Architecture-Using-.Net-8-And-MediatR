using Microsoft.EntityFrameworkCore;
using MyCleanArchitectureApp.Core.Entities;

namespace MyCleanArchitectureApp.Infrastructure.Data
{
	/// <summary>
	/// AppDbContext
	/// </summary>
	/// <param name="options"></param>
	public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
		/// <summary>
		/// Employees DbSet
		/// </summary>
		public DbSet<EmployeeEntity> Employees { get; set; }
	}
}
