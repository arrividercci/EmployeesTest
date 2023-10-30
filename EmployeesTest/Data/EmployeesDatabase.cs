using EmployeesTest.Models.Entities;

namespace EmployeesTest.Data
{
    public class EmployeesDatabase
    {
        public List<Employee> employees = new List<Employee>()
        {
            new Employee()
            {
                Id = Guid.NewGuid(),
                FirstName = "FirstName0",
                LastName = "Lastname0",
                Patronimyc = "Patronimyc0",
                Birthday = DateTime.Now,
                Departament = "Departament0",
                Position = "Position0",
                Salary = 1000
            },
            new Employee()
            {
                Id = Guid.NewGuid(),
                FirstName = "FirstName1",
                LastName = "Lastname1",
                Patronimyc = "Patronimyc1",
                Birthday = DateTime.Now,
                Departament = "Departament1",
                Position = "Position1",
                Salary = 1001
            },
            new Employee()
            {
                Id = Guid.NewGuid(),
                FirstName = "FirstName2",
                LastName = "Lastname2",
                Patronimyc = "Patronimyc2",
                Birthday = DateTime.Now,
                Departament = "Departament2",
                Position = "Position2",
                Salary = 1002
            },
            new Employee()
            {
                Id = Guid.NewGuid(),
                FirstName = "FirstName3",
                LastName = "Lastname3",
                Patronimyc = "Patronimyc3",
                Birthday = DateTime.Now,
                Departament = "Departament3",
                Position = "Position3",
                Salary = 1003
            },
            new Employee()
            {
                Id = Guid.NewGuid(),
                FirstName = "FirstName4",
                LastName = "Lastname4",
                Patronimyc = "Patronimyc4",
                Birthday = DateTime.Now,
                Departament = "Departament4",
                Position = "Position4",
                Salary = 1004
            },

        };
    }
}
