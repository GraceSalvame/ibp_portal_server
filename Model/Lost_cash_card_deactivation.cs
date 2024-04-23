using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ibp_portal_server.Model
{
    public class Lost_cash_card_deactivation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int request_id { get; set; } //Foreign key property
        public Request Request { get; set; } //Navigation property

        [Required]
        [Column(TypeName = "nvarchar(30)")]
        public string cash_card_number { get; set; }

        [Required]
        [Column(TypeName = "tinyint")]
        public byte physically_collected_cash_card { get; set; }
    }
}
