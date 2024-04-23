using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ibp_portal_server.Model
{
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int payment_type_id { get; set; } //Foreign key property
        public Payout_type Payout_type { get; set; } //Navigation property

        [Required]
        public DateTime date_created { get; set; }

        //Navigation property
        public ICollection<Payment_transaction> Payment_transactions { get; set; }
        public ICollection<Payment_detail> Payment_details { get; set; }
    }
}
