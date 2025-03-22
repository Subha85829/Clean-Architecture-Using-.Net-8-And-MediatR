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
	/// Get Employee by Id Query
	/// </summary>
	/// <param name="id"></param>
	public record GetEmployeeByIdQuery(Guid id) : IRequest<EmployeeEntity>;

	/// <summary>
	/// Get Employee by Id Query Handler
	/// </summary>
	public class GetEmployeeByIdQueryHandler : IRequestHandler<GetEmployeeByIdQuery, EmployeeEntity>
    {
		/// <summary>
		/// Employee Repository
		/// </summary>
		readonly IEmployeeRepository _employeeRepository;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="employeeRepository"></param>
		public GetEmployeeByIdQueryHandler(IEmployeeRepository employeeRepository)
		{
			_employeeRepository = employeeRepository;
		}

		/// <summary>
		/// Handle Get Employee by Id Query
		/// </summary>
		/// <param name="request"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<EmployeeEntity?> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
		{
			return await _employeeRepository.GetEmployeeById(request.id, cancellationToken);
		}

	}
}
