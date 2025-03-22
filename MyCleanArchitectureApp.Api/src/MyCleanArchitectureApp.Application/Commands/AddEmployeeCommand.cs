using MediatR;
using MyCleanArchitectureApp.Core.Entities;
using MyCleanArchitectureApp.Core.Interfaces;

namespace MyCleanArchitectureApp.Application.Commands
{
    public record AddEmployeeCommand(EmployeeEntity EmployeeEntity) : IRequest<EmployeeEntity>;


	public class AddEmployeeCommandHandler : IRequestHandler<AddEmployeeCommand, EmployeeEntity>
	{
		/// <summary>
		/// IEmployeeRepository variable
		/// </summary>
		readonly IEmployeeRepository _employeeRepository;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="employeeRepository"></param>
		public AddEmployeeCommandHandler(IEmployeeRepository employeeRepository)
		{
			_employeeRepository = employeeRepository;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<EmployeeEntity> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
		{
			return await _employeeRepository.AddEmployeeAsync(request.EmployeeEntity, cancellationToken);
		}
	}
}
