using System.ComponentModel.DataAnnotations;

namespace Management.Models
{
    public class SupplierMaster
    {

        [Key]
        public int SupplierId { get; set; }

        [Required(ErrorMessage = "Supplier Name is required")]
        [StringLength(100)]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Supplier Name can only contain letters.")]
        public string SupplierName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone is required")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Phone number must be exactly 10 digits")]
        public string Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Purchase Date is required")]
        public DateTime PurchaseDate { get; set; } = DateTime.Today;

        public bool IsActive { get; set; } = true;


    }
}
