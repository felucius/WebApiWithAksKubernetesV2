using WebApi.Services;

namespace WebApi.Model
{
	public class Employee : IEmployee
	{
		/// <summary>
		/// Name 
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Age
		/// </summary>
		public int Age { get; set; }

		/// <summary>
		/// Company
		/// </summary>
		public Company Company { get; set; }

		/// <summary>
		/// Job
		/// </summary>
		public Job Job { get; set; }

		public Employee()
		{

		}
	}
}
