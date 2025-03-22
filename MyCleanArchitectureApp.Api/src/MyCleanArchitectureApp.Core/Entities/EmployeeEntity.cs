namespace MyCleanArchitectureApp.Core.Entities
{
	/// <summary>
	/// Employee Entity
	/// </summary>
	public class EmployeeEntity
    {
		/// <summary>
		/// Id
		/// </summary>
		public Guid Id { get; set; }

		/// <summary>
		/// Name
		/// </summary>
		public string Name { get; set; } = null!;

		/// <summary>
		/// Email
		/// </summary>
		public string Email { get; set; } = null!;

		/// <summary>
		/// Phone
		/// </summary>
		public string Phone { get; set; } = null!;
	}
}
