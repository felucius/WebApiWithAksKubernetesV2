using WebApi.Services;

namespace WebApi.Model
{
	public class Job : IJob
	{
		/// <summary>
		/// ID
		/// </summary>
		public int ID { get; set; }

		/// <summary>
		/// Job title
		/// </summary>
		public string JobTitle { get; set; }

		/// <summary>
		/// Working hours
		/// </summary>
		public int WorkingHours { get; set; }

		/// <summary>
		/// Salary
		/// </summary>
		public int Salary { get; set; }

		public Job()
		{

		}
	}
}
