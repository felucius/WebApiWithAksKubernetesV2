using WebApi.Model;

namespace WebApi.Services
{
	public interface IEmployee
	{
		/// <summary>
		/// ID
		/// </summary>
		int ID { get; set; }

		/// <summary>
		/// Name
		/// </summary>
		string Name { get; set; }

		/// <summary>
		/// Age
		/// </summary>
		int Age { get; set; }

		/// <summary>
		/// The company where the person works at
		/// </summary>
		Company Company { get; set; }

		/// <summary>
		/// Job
		/// </summary>
		Job Job { get; set; }
	}
}
