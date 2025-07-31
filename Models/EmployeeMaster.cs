using System.ComponentModel.DataAnnotations;

namespace Management.Models
{
    public class EmployeeMaster
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(100)]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Position is required")]
        public string Position { get; set; }

       
    }
}
