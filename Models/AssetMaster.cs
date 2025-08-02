using System.ComponentModel.DataAnnotations;

namespace Management.Models
{
    public class AssetMaster
    {
        [Key]
        public int AssetId { get; set; }

        
        [Required(ErrorMessage = "Asset Name is required")]
        public string AssetName { get; set; }

        [Required(ErrorMessage = "Asset Type is required")]
        public string AssetType { get; set; }

        [Required(ErrorMessage = "Serial Number is required")]
        public string SerialNumber { get; set; }

        [Required(ErrorMessage = "SupplierId is required")]
        public int SupplierId { get; set; }

    }
}

