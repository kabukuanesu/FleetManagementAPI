using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FleetManagementAPI.Models
{
    public class Driver
    {
        [Key]
        public int DriverId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string DriverName { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string DriverCompanyId { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string DriverMobileNumber { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string DriverAddress { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string DriverAge { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string DriverLicenseNumber { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string DriverLicenseExpiryDate { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string DriverTotalExperience { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string DriverDateOfJoining { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string DriverIsActive { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string DriverCreatedBy { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string DriverCreatedDate { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string DriverModifiedDate { get; set; } = "";

        [Column(TypeName = "varbinary(max)")]
        public byte[]? DriverDocument { get; set; } // This column will store the file data
    }
}
