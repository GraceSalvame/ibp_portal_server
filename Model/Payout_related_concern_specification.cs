using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ibp_portal_server.Model
{
    public class Payout_related_concern_specification
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string name { get; set; }

        [Column(TypeName = "ntext")]
        public string description { get; set; }

        public int payout_related_concern_id { get; set; } //Foreign key property
        public Payout_related_concern Payout_related_concern { get; set; } //Navigation property

        //Navigation property
        public ICollection<Payout_related_concern_sub_specification> Payout_related_concern_sub_specifications { get; set; }
    }
}
