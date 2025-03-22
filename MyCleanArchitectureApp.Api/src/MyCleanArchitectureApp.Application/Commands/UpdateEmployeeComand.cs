using MediatR;
using MyCleanArchitectureApp.Core.Entities;
using MyCleanArchitectureApp.Core.Interfaces;

namespace MyCleanArchitectureApp.Application.Commands
{
	/// <summary>
	/// Update Employee Command
	/// </summary>
	/// <param name="EmployeeId"></param>
	/// <param name="EmployeeEntity"></param>
	public record UpdateEmployeeComand(Guid EmployeeId, EmployeeEntity EmployeeEntity) : IRequest<EmployeeEntity>;

	/// <summary>
	/// Update Employee Command Handler
	/// </summary>
	public class UpdateEmployeeComandHandler : IRequestHandler<UpdateEmployeeComand, EmployeeEntity>
	{
		/// <summary>
		/// IEmployeeRepository variable
		/// </summary>
		readonly IEmployeeRepository _employeeRepository;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="employeeRepository"></param>
		public UpdateEmployeeComandHandler(IEmployeeRepository employeeRepository)
		{
			_employeeRepository = employeeRepository;
		}

		/// <summary>
		/// Handle method
		/// </summary>
		/// <param name="request"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<EmployeeEntity?> Handle(UpdateEmployeeComand request, CancellationToken cancellationToken)
		{
			return await _employeeRepository.UpdateEmployeeAsync(request.EmployeeId, request.EmployeeEntity, cancellationToken);
		}
	}
}
