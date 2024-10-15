using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FleetManagementAPI.Models
{
    public class MoneyFlow
    {
        [Key]
        [Column(TypeName = "nvarchar(100)")]
        public int MoneyFlowId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string MoneyFlowCompanyId { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string MoneyFlowDate { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string MoneyFlowType { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string MoneyFlowDescription { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string MoneyFlowAmount { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string MoneyFlowCreatedDate { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string MoneyFlowModifiedDate { get; set; } = "";
    }
}
