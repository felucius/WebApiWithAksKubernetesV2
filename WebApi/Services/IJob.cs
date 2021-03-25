
namespace WebApi.Services
{
	public interface IJob
	{
		/// <summary>
		/// Job title
		/// </summary>
		string JobTitle { get; set; }

		/// <summary>
		/// Working hours
		/// </summary>
		int WorkingHours { get; set; }

		/// <summary>
		/// Salary
		/// </summary>
		int Salary { get; set; }
	}
}
