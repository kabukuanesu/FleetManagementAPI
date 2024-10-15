using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FleetManagementAPI.Models
{
    public class Geofence
    {
        [Key]
        public int GeofenceId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string GeofenceName { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string GeofenceDescription { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string GeofenceArea { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string GeofenceVehicles { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string GeofenceCreateDate { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string GeofenceModifiedDate { get; set; } = "";
    }
}
