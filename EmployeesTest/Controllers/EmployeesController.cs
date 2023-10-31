using EmployeesTest.Contracts;
using EmployeesTest.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesTest.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeeService employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        public ActionResult Index(string searchString = "")
        {
            var employees = employeeService
                .GetByCondition(emploee => emploee.LastName.Contains(searchString,StringComparison.OrdinalIgnoreCase) || 
                emploee.Departament.Contains(searchString, StringComparison.OrdinalIgnoreCase) || 
                emploee.Position.Contains(searchString, StringComparison.OrdinalIgnoreCase));
            return View(employees);
        }

        public ActionResult Details(Guid id)
        {
            var employee = employeeService.GetById(id);

            return View(employee);
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            try
            {
                employeeService.CreateEmployee(employee);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Edit(Guid id)
        {
            var employee = employeeService.GetById(id);
            return View(employee);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, Employee employee)
        {
            try
            {
                employeeService.UpdateEmployee(id, employee);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Delete(Guid id)
        {
            var employee = employeeService.GetById(id);

            return View(employee);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, Employee employee)
        {
            try
            {
                employeeService.RemoveEmployee(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
