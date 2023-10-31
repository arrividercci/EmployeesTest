using EmployeesTest.Contracts;
using EmployeesTest.Data;
using EmployeesTest.Models.Entities;
using System.Linq;
using System.Linq.Expressions;

namespace EmployeesTest.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeesDatabase database;

        public EmployeeService(EmployeesDatabase database)
        {
            this.database = database;
        }

        public void CreateEmployee(Employee employee)
        {
            employee.Id = Guid.NewGuid();

            database.employees.Add(employee);
        }

        public List<Employee> GetAll()
        {
            return database.employees;
        }

        public List<Employee> GetByCondition(Func<Employee, bool> expression)
        {
            return database.employees.Where(expression).ToList();
        }

        public Employee GetById(Guid id)
        {
            var employee = database.employees.FirstOrDefault(employee => employee.Id.Equals(id));

            if (employee == null)
            {
                throw new ArgumentException();
            }

            return employee;
        }

        public void RemoveEmployee(Guid id)
        {
            var employee = GetById(id);

            if (employee == null)
            {
                throw new ArgumentException();
            }

            database.employees.Remove(employee);
        }

        public void UpdateEmployee(Guid id, Employee employeeForUpdate)
        {
            var employee = GetById(id);

            if (employee == null)
            {
                throw new ArgumentException();
            }

            employeeForUpdate.Id = employee.Id;

            var index = database.employees.IndexOf(employee);

            database.employees[index] = employeeForUpdate;

        }
    }
}
