using System.ComponentModel.DataAnnotations;

namespace Demo.BusinessLogic.DTOs.Employees
{
    public class EmployeeDTO
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Max length should be 50 character")]
        [MinLength(5, ErrorMessage = "Min length should be 5 characters")]
        public string Name { get; set; } = null!;

        [Range(22, 30)]
        public int? Age { get; set; }

        [DataType(DataType.Currency)]
        public decimal? Salary { get; set; }

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; } = true;

        [EmailAddress]
        public string? Email { get; set; }

        public string Gender { get; set; }

        public string EmployeeType { get; set; }
    }
}