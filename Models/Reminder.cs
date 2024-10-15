using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FleetManagementAPI.Models
{
    public class Reminder
    {
        [Key]
        public int ReminderId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string ReminderCompanyId { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string ReminderDate { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string ReminderMessage { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string ReminderIsRead { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string ReminderCreatedDate { get; set; } = "";
    }
}
