using Management.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class EmployeeAsset
{
    [Key]
    public int EmpAssetId { get; set; }

    [Required(ErrorMessage = "Please select an employee.")]
    [Range(1, int.MaxValue, ErrorMessage = "Please select a valid employee.")] // Ensures EmployeeId is greater than 0
    [ForeignKey("Employee")]
    public int EmployeeId { get; set; }

    [Required(ErrorMessage = "Please select an asset.")]
    [Range(1, int.MaxValue, ErrorMessage = "Please select a valid asset.")] // Ensures AssetId is greater than 0
    [ForeignKey("Asset")]
    public int AssetId { get; set; }

    // Removed [Required] from AssetName and AssetType as they are derived from the selected Asset
    [StringLength(100)]
    public string? AssetName { get; set; }

    [StringLength(50)]
    public string? AssetType { get; set; }

    [Required(ErrorMessage = "Issue Date is required")]
    public DateTime IssueDate { get; set; }

    // Navigation properties
    public EmployeeMaster? Employee { get; set; }

    public AssetMaster? Asset { get; set; }
}