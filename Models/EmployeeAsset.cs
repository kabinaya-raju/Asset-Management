using Management.Models;
using System.ComponentModel.DataAnnotations;

public class EmployeeAsset
{
    [Key]
    public int EmpAssetId { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please select an employee.")]
    public int EmployeeId { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please select an asset.")]
    public int AssetId { get; set; }


    [StringLength(100)]
    public string? AssetName { get; set; }

   
    [StringLength(50)]
    public string? AssetType { get; set; }

    [Required]
    public DateOnly IssueDate { get; set; }

    public EmployeeMaster? Employee { get; set; }

    public AssetMaster? Asset { get; set; }
}
