using System.ComponentModel.DataAnnotations;

namespace Management.Models
{
    public class AssetMaster
    {
        [Key]
        public int AssetId { get; set; }

        [Required]
        [StringLength(100)]
        public string AssetName { get; set; }

        [Required]
        [StringLength(50)]
        public string AssetType { get; set; }

        [StringLength(50)]
        public string SerialNumber { get; set; }

    }
}

