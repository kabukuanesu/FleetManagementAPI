using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FleetManagementAPI.Models
{
    public class Trip
    {
        [Key]
        public int TripId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string TripCustomerId { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string TripType { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string TripDriver { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string TripStartDate { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string TripEndDate { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string TripFromLocation { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string TripToLocation { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string TripTotalDistance { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string TripAmount { get; set; } = "";

        /*[Column(TypeName = "nvarchar(100)")]
        public string TripStatus { get; set; } = "";*/

        private string _tripStatus = "Scheduled";
        [Column(TypeName = "nvarchar(100)")]
        public string TripStatus
        {
            get { return _tripStatus; }
            set { _tripStatus = string.IsNullOrWhiteSpace(value) ? "Scheduled" : value; }
        }

        [Column(TypeName = "nvarchar(100)")]
        public string TripTrackingCode { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string TripCreatedBy { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public DateTime TripCreatedDate { get; set; } = DateTime.Now;

        [Column(TypeName = "nvarchar(100)")]
        public DateTime TripModifiedDate { get; set; } = DateTime.Now;
    }
}
