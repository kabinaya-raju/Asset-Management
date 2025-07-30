using System.ComponentModel.DataAnnotations;

namespace Management.Models
{
    public class EmployeeMaster
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(100)]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string Position { get; set; }

       
    }
}
