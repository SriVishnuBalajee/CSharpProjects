namespace NWinMVC.Models
{
	public class RepositoryEmp
	{
		private NorthwindContext _context;
		public RepositoryEmp(NorthwindContext context)
		{
			_context = context;
		}
		public List<Employee> AllEmployee()
		{
			return _context.Employees.ToList();
		}
		public static List<Employee> AllEmployees()
		{
			NorthwindContext ctx = new NorthwindContext();
			return ctx.Employees.ToList();
		}
	}
}
