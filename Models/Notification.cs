using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FleetManagementAPI.Models
{
    public class Notification
    {
        [Key]
        public int NotificationId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string NotificationSubject { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string NotificationMessage { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string NotificationIsRead { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string NotificationCreatedDate { get; set; } = "";
    }
}
