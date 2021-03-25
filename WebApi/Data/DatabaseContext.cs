using Microsoft.EntityFrameworkCore;
using WebApi.Model;

namespace WebApi.Data
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
		{

		}

		// Database sets
		public DbSet<Job> Jobs { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Company> Companies { get; set; }
	}
}
