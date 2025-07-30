using System.ComponentModel.DataAnnotations;

namespace Management.Models
{
    public class SupplierMaster
    {

        [Key]
        public int SupplierId { get; set; }

        [Required]
        [StringLength(100)]
        public string SupplierName { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [Required]
        public DateOnly PurchaseDate { get; set; }


    }
}
