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
        public DateTime DriverDateOfJoining { get; set; } = DateTime.Now;

        /*[Column(TypeName = "nvarchar(100)")]
        public string DriverIsActive { get; set; } = "";*/

        private string _driverIsActive = "Standby";
        [Column(TypeName = "nvarchar(100)")]
        public string DriverIsActive
        {
            get { return _driverIsActive; }
            set { _driverIsActive = string.IsNullOrWhiteSpace(value) ? "Standby" : value; }
        }

        [Column(TypeName = "nvarchar(100)")]
        public string DriverCreatedBy { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public DateTime DriverCreatedDate { get; set; } = DateTime.Now;

        [Column(TypeName = "nvarchar(100)")]
        public DateTime DriverModifiedDate { get; set; } = DateTime.Now;

        [Column(TypeName = "varbinary(max)")]
        public byte[]? DriverDocument { get; set; } // This column will store the file data
    }
}
