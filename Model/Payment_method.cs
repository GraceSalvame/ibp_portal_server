using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ibp_portal_server.Model
{
    public class Payment_method
    {
        [Key]
        DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [ForeignKey("Ibp")]
        public int ibp_id { get; set; }
        public Ibp Ibp { get; set; }

        [ForeignKey("Payment_channel")]
        public int Payment_channel_id { get; set; }
        public Payment_channel Payment_channel { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string card_no { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string account_no { get; set; }

        [ForeignKey("Status")]
        public int status_id { get; set; }
        public Status Status { get; set; }
    }
}
