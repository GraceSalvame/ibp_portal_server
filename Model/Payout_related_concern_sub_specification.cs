using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ibp_portal_server.Model
{
    public class Payout_related_concern_sub_specification
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string name { get; set; }

        [Column(TypeName = "ntext")]
        public string description { get; set; }

        public int payout_related_concern_specification_id { get; set; } //Foreign key property
        public Payout_related_concern_specification Payout_related_concern_specification { get; set; } //Navigation property
    }
}
