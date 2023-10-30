using EmployeesTest.Models.Entities;
using System.Linq.Expressions;

namespace EmployeesTest.Contracts
{
    public interface IEmployeeService
    {
        Employee GetById(Guid id);
        List<Employee> GetAll();
        List<Employee> GetByCondition(Func<Employee, bool> expression);
        void CreateEmployee(Employee employee);
        void UpdateEmployee(Guid id, Employee employee);
        void RemoveEmployee(Guid id);
    }
}
