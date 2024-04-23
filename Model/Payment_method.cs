using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ibp_portal_server.Model
{
    public class Payment_method
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int ibp_id { get; set; } //Foreign key property
        public Ibp Ibp { get; set; } //Navigation property

        public int payment_channel_id { get; set; }  //Foreign key property
        public Payment_channel Payment_channel { get; set; } //Navigation property

        [Column(TypeName = "nvarchar(30)")]
        public string card_no { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string account_no { get; set; }

        public int status_id { get; set; }  //Foreign key property
        public Status Status { get; set; } //Navigation property
    }
}
