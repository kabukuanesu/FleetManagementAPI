using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FleetManagementAPI.Models
{
    public class TripPayment
    {
        [Key]
        public int TripPaymentId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string TripPaymentTripId { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string TripPaymentVehicleId { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string TripPaymentAmount { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string TripPaymentNotes { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string TripPaymentCreatedDate { get; set; } = "";
    }
}
