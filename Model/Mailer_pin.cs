using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ibp_portal_server.Model
{
    public class Mailer_pin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int request_id { get; set; } //Foreign key property
        public Request Request { get; set; } //Navigation property

        [Required]
        [Column(TypeName = "nvarchar(30)")]
        public string card_number { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string card_account_number { get; set; }
    }
}
