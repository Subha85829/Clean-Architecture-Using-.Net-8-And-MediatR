using Microsoft.EntityFrameworkCore;
using MyCleanArchitectureApp.Core.Entities;
using MyCleanArchitectureApp.Core.Interfaces;
using MyCleanArchitectureApp.Infrastructure.Data;

namespace MyCleanArchitectureApp.Infrastructure.Repositories
{
    class EmployeeRepository(AppDbContext dbContext) : IEmployeeRepository
	{
		/// <summary>
		/// AppDbContext
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<IEnumerable<EmployeeEntity>> GetEmployees(CancellationToken cancellationToken)
        {
            return await dbContext.Employees.ToListAsync();
        }

		/// <summary>
		/// Get Employee by Id
		/// </summary>
		/// <param name="id"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<EmployeeEntity?> GetEmployeeById(Guid id, CancellationToken cancellationToken)
		{
			return await dbContext.Employees.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
		}

		/// <summary>
		/// Add Employee
		/// </summary>
		/// <param name="employeeEntity"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<EmployeeEntity> AddEmployeeAsync(EmployeeEntity employeeEntity, CancellationToken cancellationToken)
		{
			employeeEntity.Id = Guid.NewGuid();
			await dbContext.Employees.AddAsync(employeeEntity, cancellationToken);
			await dbContext.SaveChangesAsync(cancellationToken);
			return employeeEntity;
		}

		/// <summary>
		/// Update Employee
		/// </summary>
		/// <param name="employeeId"></param>
		/// <param name="employeeEntity"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<EmployeeEntity?> UpdateEmployeeAsync(Guid employeeId, EmployeeEntity employeeEntity, CancellationToken cancellationToken)
		{
			var employee = await GetEmployeeById(employeeId, cancellationToken);
			if (employee is not null) 
			{
				employee.Name = employeeEntity.Name;
				employee.Email = employeeEntity.Email;
				employee.Phone = employeeEntity.Phone;

				await dbContext.SaveChangesAsync(cancellationToken);
				return employee;
			}
			return employee;
		}

		/// <summary>
		/// Delete Employee
		/// </summary>
		/// <param name="id"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<bool> DeleteEmployeeAsync(Guid id, CancellationToken cancellationToken)
		{
			var employee = await GetEmployeeById(id, cancellationToken);
			if(employee is not null)
			{
				dbContext.Employees.Remove(employee);
				return await dbContext.SaveChangesAsync(cancellationToken) > 0;
			}
			return false;
		}
	}
}
