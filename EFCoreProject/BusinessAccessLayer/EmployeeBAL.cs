using EFCoreProject.DataAccessLayer;
using EFCoreProject.model;


namespace EFCoreProject.BusinessAccessLayer
{
    public class EmployeeBAL
    {
        private readonly EmployeeDAL _employeeDAL;
        public EmployeeBAL(EmployeeDAL EmployeeDAL)
        {
            _employeeDAL = EmployeeDAL;
        }


        public Employee GetEmployee(int id)
        {
            return _employeeDAL.GetEmployee(id);
        }


        public List<Employee> GetAllEmployees()
        {
            return _employeeDAL.GetAllEmployees();
        }

        public void AddEmployee(Employee employee)
        {
            _employeeDAL.AddEmployee(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            _employeeDAL.UpdateEmployee(employee);
        }

        public void DeleteEmployee(int id)
        {
            _employeeDAL.DeleteEmployee(id);
        }
    }
}
