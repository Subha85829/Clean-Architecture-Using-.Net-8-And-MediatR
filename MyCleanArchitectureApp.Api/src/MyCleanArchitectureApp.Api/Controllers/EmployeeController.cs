using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyCleanArchitectureApp.Application.Commands;
using MyCleanArchitectureApp.Application.Queries;
using MyCleanArchitectureApp.Core.Entities;

namespace MyCleanArchitectureApp.Api.Controllers
{
    [Route("api/[controller]")]
	[ApiVersion("1.0")]
	[ApiController]
	
	public class EmployeeController : ControllerBase
    {
		/// <summary>
		/// Isender variable
		/// </summary>
        readonly ISender _sender;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="sender"></param>
		public EmployeeController(ISender sender)
		{
			_sender = sender;
		}

		/// <summary>
		/// Get all Employees
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		[HttpGet]
		[Route("employees")]
		public async Task<IActionResult> GetAllEmployeesAsync(CancellationToken cancellationToken = default)
		{
			var result = await _sender.Send(new GellAllEmployeesQuery(), cancellationToken);
			return Ok(result);
		}

		/// <summary>
		/// Get Employee by Id
		/// </summary>
		/// <param name="employeeId"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		[HttpGet]
		[Route("{employeeId}")]
		public async Task<IActionResult> GetEmployeeByIdAsync([FromRoute] Guid employeeId, CancellationToken cancellationToken = default)
		{
			var result = await _sender.Send(new GetEmployeeByIdQuery(employeeId), cancellationToken);
			if (result is not null)
			{
				return Ok(result);
			}			
			return NotFound("User id is not found!");
		}

		/// <summary>
		/// Add Employee
		/// </summary>
		/// <param name="employeeEntity"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		[HttpPost]
		[Route("")]
		public async Task<IActionResult> AddEmployeesAsync([FromBody] EmployeeEntity employeeEntity, CancellationToken cancellationToken = default)
		{
            var result = await _sender.Send(new AddEmployeeCommand(employeeEntity), cancellationToken);
			return Ok(result);
		}

		/// <summary>
		/// Update Employee
		/// </summary>
		/// <param name="employeeId"></param>
		/// <param name="employeeEntity"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		[HttpPut]
		[Route("{employeeId}")]
		public async Task<IActionResult> UpdateEmployeesAsync([FromRoute] Guid employeeId, [FromBody] EmployeeEntity employeeEntity, CancellationToken cancellationToken = default)
		{
			var result = await _sender.Send(new UpdateEmployeeComand(employeeId, employeeEntity), cancellationToken);
			if (result is not null)
			{
				return Ok(result);
			} 
			return BadRequest("Please provide the proper id!");
		}

		/// <summary>
		/// Delete Employee
		/// </summary>
		/// <param name="employeeId"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		[HttpDelete]
		[Route("{employeeId}")]
		public async Task<IActionResult> DeleteEmployeesAsync([FromRoute] Guid employeeId, CancellationToken cancellationToken = default)
		{
			var result = await _sender.Send(new DeleteEmployeeComand(employeeId), cancellationToken);
			if (result)
			{
				return Ok("Employee deleted successfully!");
			}
			return BadRequest("Please provide the proper id! As this Id does not exists!");
		}
	}
}
