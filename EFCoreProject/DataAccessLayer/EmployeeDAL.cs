using EFCoreProject.model;

namespace EFCoreProject.DataAccessLayer
{
    public class EmployeeDAL
    {
        private readonly Database.CompnayDbContext _context;
        public EmployeeDAL(Database.CompnayDbContext context)
        {
            _context = context;
        }


        public List<model.Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public Employee GetEmployee(int id)
        {
            return _context.Employees.Find(id);
        }

        public void AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            _context.Employees.Update(employee);
            //_context.Entry(employee).Property(s => s.Name).IsModified = true;
            _context.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
        }
    }
}
