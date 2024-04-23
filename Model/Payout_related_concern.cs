using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ibp_portal_server.Model
{
    public class Payout_related_concern
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int request_id { get; set; } //Foreign key property
        public Request Request { get; set; } //Navigation property

        [Required]
        public int customer_code { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string customer_name { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string account_code { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string sales_invoice_no { get; set; }

        [Required]
        public DateTime? sales_invoice_date { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string subject { get; set; }

        [Required]
        [Column(TypeName = "ntext")]
        public string justification { get; set; }

        //Navigation property
        public ICollection<Payout_related_concern_specification> Payout_related_concern_specifications { get; set; }
    }
}
