namespace EmployeesTest.Models.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronimyc { get; set; }
        public DateTime Birthday { get; set; }
        public string Departament { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

    }
}
