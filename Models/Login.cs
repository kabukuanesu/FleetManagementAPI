using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FleetManagementAPI.Models
{
    public class Login
    {
        [Key]
        public int UserId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string UserName { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string UserUserName { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string UserPassword { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string UserIsActive { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string UserEmail { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string UserCreatedDate { get; set; } = ""; 
    }
}
