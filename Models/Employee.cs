using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string    EmpName { get; set; }
        public int EmpSalary { get; set; }
    }
}
