using MediatR;
using MyCleanArchitectureApp.Core.Interfaces;

namespace MyCleanArchitectureApp.Application.Commands
{
	/// <summary>
	/// Delete Employee Command
	/// </summary>
	/// <param name="EmployeeId"></param>
	public record DeleteEmployeeComand(Guid EmployeeId) : IRequest<bool>;


	/// <summary>
	/// Delete Employee Command Handler
	/// </summary>
	public class DeleteEmployeeComandHandler : IRequestHandler<DeleteEmployeeComand, bool>
	{
		/// <summary>
		/// IEmployeeRepository variable
		/// </summary>
		readonly IEmployeeRepository _employeeRepository;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="employeeRepository"></param>
		public DeleteEmployeeComandHandler(IEmployeeRepository employeeRepository)
		{
			_employeeRepository = employeeRepository;
		}

		/// <summary>
		/// Handle method
		/// </summary>
		/// <param name="request"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<bool> Handle(DeleteEmployeeComand request, CancellationToken cancellationToken)
		{
			return await _employeeRepository.DeleteEmployeeAsync(request.EmployeeId, cancellationToken);
		}
	}
}
