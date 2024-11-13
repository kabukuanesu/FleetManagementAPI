using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FleetManagementAPI.Models
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string VehicleRegistrationNumber { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string VehicleName { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string VehicleModel { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string VehicleChassisNumber { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string VehicleEngineNumber { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string VehicleManufacturedBy { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string VehicleType { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string VehicleFuelType { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string VehicleColor { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string VehicleMilagePerLitre { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string VehicleIsActive { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string VehicleRegistrationExpiryDate { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string VehicleCreatedBy { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public DateTime VehicleCreatedDate { get; set; } = DateTime.Now;

        [Column(TypeName = "nvarchar(100)")]
        public DateTime VehicleModifiedDate { get; set; } = DateTime.Now;
    }
}
