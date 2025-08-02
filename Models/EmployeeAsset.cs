using Management.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class EmployeeAsset
{
    [Key]
    public int AssignmentId { get; set; }

    [Required(ErrorMessage = "Employee is required")]
    public int EmployeeId { get; set; }

    [Required(ErrorMessage = "Asset is required")]
    public int AssetId { get; set; }

    [Required(ErrorMessage = "Issue Date is required")]
    public DateTime IssueDate { get; set; } = DateTime.Today;

   
    [ForeignKey("EmployeeId")]
    public EmployeeMaster? Employee { get; set; }

    [ForeignKey("AssetId")]
    public AssetMaster? Asset { get; set; }
}