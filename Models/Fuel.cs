using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FleetManagementAPI.Models
{
    public class Fuel
    {
        [Key]
        public int VehicleFuelId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string VehicleRegistrationId { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string VehicleFuelQuantity { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string VehicleFuelType { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string OdometerReading { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string VehicleFuelPrice { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string VehicleFuelFillDate { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string VehicleFuelAddedBy { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string VehicleFuelComments { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string VehicleFuelCreatedDate { get; set; } = "";
    }
}
