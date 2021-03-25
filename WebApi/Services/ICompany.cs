
using System.Collections.Generic;
using WebApi.Model;

namespace WebApi.Services
{
	public interface ICompany
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
		/// Address
		/// </summary>
		string Address { get; set; }

		/// <summary>
		/// Amount of employees
		/// </summary>
		int AmountOfEmployees { get; set; }

		/// <summary>
		/// Get all employees
		/// </summary>
		List<Employee> Employees { get; set; }

		/// <summary>
		/// Established since
		/// </summary>
		int EstablishedSince { get; set; }

		/// <summary>
		/// Add an employee
		/// </summary>
		/// <param name="employee"></param>
		void AddEmployee(Employee employee);

		/// <summary>
		/// Get all available employees
		/// </summary>
		/// <returns></returns>
		List<Employee> GetEmployees();
	}
}
