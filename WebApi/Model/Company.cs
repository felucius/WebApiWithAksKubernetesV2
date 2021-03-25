using System.Collections.Generic;
using WebApi.Services;

namespace WebApi.Model
{
	public class Company : ICompany
	{
		/// <summary>
		/// Name
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Address
		/// </summary>
		public string Address { get; set; }

		/// <summary>
		/// Amount of employees
		/// </summary>
		public int AmountOfEmployees { get; set; }

		/// <summary>
		/// Employees
		/// </summary>
		public List<Employee> Employees { get; set; }

		/// <summary>
		/// Established since
		/// </summary>
		public int EstablishedSince { get; set; }

		public Company()
		{
			this.Employees = new List<Employee>();
		}

		/// <summary>
		/// Add an employee to the list
		/// </summary>
		/// <param name="employee"></param>
		public void AddEmployee(Employee employee)
		{
			this.Employees.Add(employee);
		}

		/// <summary>
		/// Return all the available employees
		/// </summary>
		/// <returns></returns>
		public List<Employee> GetEmployees()
		{
			return this.Employees;
		}
	}
}
