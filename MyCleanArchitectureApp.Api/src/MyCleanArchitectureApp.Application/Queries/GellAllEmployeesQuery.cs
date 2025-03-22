using MediatR;
using MyCleanArchitectureApp.Core.Entities;
using MyCleanArchitectureApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCleanArchitectureApp.Application.Queries
{
	/// <summary>
	/// Get all Employees Query
	/// </summary>
	public record GellAllEmployeesQuery() : IRequest<IEnumerable<EmployeeEntity>>;

	/// <summary>
	/// Get all Employees Query Handler
	/// </summary>
	public class GellAllEmployeesQueryHandler : IRequestHandler<GellAllEmployeesQuery, IEnumerable<EmployeeEntity>>
	{
		/// <summary>
		/// Employee Repository
		/// </summary>
		readonly IEmployeeRepository _employeeRepository;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="employeeRepository"></param>
		public GellAllEmployeesQueryHandler(IEmployeeRepository employeeRepository)
		{
			_employeeRepository = employeeRepository;
		}

		/// <summary>
		/// Handle
		/// </summary>
		/// <param name="request"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<IEnumerable<EmployeeEntity>> Handle(GellAllEmployeesQuery request, CancellationToken cancellationToken)
		{
			return await _employeeRepository.GetEmployees(cancellationToken);
		}
	}
}
