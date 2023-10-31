using System.ComponentModel.DataAnnotations;

namespace EmployeesTest.Models.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Це поле не може бути порожнім")]
        [StringLength(100,MinimumLength = 1, ErrorMessage = "Допустима довжина від 1 до 100 символів")]
        [Display(Name = "Ім'я")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Це поле не може бути порожнім")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Допустима довжина від 1 до 100 символів")]
        [Display(Name = "Прізвище")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Це поле не може бути порожнім")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Допустима довжина від 1 до 100 символів")]
        [Display(Name = "По батькові")]
        public string Patronimyc { get; set; }
        [Required(ErrorMessage = "Це поле не може бути порожнім")]
        [Display(Name = "Дата народження")]
        public DateTime Birthday { get; set; }
        [Required(ErrorMessage = "Це поле не може бути порожнім")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Допустима довжина від 1 до 100 символів")]
        [Display(Name = "Департамент")]
        public string Departament { get; set; }
        [Required(ErrorMessage = "Це поле не може бути порожнім")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Допустима довжина від 1 до 100 символів")]
        [Display(Name = "Позиція")]
        public string Position { get; set; }
        [Required(ErrorMessage = "Це поле не може бути порожнім")]
        [Display(Name = "Зарплата(грн)")]
        [Range(0, int.MaxValue, ErrorMessage = "Зарплата не може бути від'ємною")]
        public double Salary { get; set; }

    }
}
