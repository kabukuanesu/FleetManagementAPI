using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FleetManagementAPI.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string CustomerName { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string CustomerCompanyId { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string CustomerMobileNumber { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string CustomerEmail { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string CustomerAddress { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string CustomerCreatedDate { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string CustomerPassword { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string CustomerIsActive { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string CustomerModifiedDate { get; set; } = "";
    }
}
