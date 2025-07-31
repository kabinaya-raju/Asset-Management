using System.ComponentModel.DataAnnotations;

namespace Management.Models
{
    public class SupplierMaster
    {

        [Key]
        public int SupplierId { get; set; }

        [Required(ErrorMessage = "Supplier Name is required")]
        [StringLength(100)]
        public string SupplierName { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [StringLength(50)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Purchase Date is required")]
        public DateTime PurchaseDate { get; set; }


    }
}
