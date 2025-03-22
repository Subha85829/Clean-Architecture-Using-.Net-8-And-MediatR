using MyCleanArchitectureApp.Core.Entities;

namespace MyCleanArchitectureApp.Core.Interfaces
{
    public interface IEmployeeRepository
    {
		/// <summary>
		/// Get all Employees
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		Task<IEnumerable<EmployeeEntity>> GetEmployees(CancellationToken cancellationToken);

		/// <summary>
		/// Get Employee by Id
		/// </summary>
		/// <param name="id"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		Task<EmployeeEntity?> GetEmployeeById(Guid id, CancellationToken cancellationToken);

		/// <summary>
		/// Add Employee
		/// </summary>
		/// <param name="employeeEntity"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		Task<EmployeeEntity> AddEmployeeAsync(EmployeeEntity employeeEntity, CancellationToken cancellationToken);

		/// <summary>
		/// Update Employee
		/// </summary>
		/// <param name="employeeId"></param>
		/// <param name="employeeEntity"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		Task<EmployeeEntity?> UpdateEmployeeAsync(Guid employeeId, EmployeeEntity employeeEntity, CancellationToken cancellationToken);

		/// <summary>
		/// Delete Employee
		/// </summary>
		/// <param name="id"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		Task<bool> DeleteEmployeeAsync(Guid id, CancellationToken cancellationToken);
	}
}
