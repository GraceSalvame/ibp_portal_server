using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ibp_portal_server.Model
{
    public class Payment_detail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int ibp_id { get; set; } //Foreign key property
        public Ibp Ibp { get; set; } //Navigation property

        public int payment_id { get; set; } //Foreign key property
        public Payment Payment { get; set; }  //Navigation property

        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string sale_type { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(30)")]
        public string account_code { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string customer_code { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string sales_invoice_no { get; set; }

        [Required]
        public DateTime sales_invoice_date { get; set; }

        [Required]
        public int total_amount { get; set; }

        [Required]
        public int total_deduction { get; set; }

        [Required]
        public int total_net_amount { get; set; }

        public int status_id { get; set; } //Foreign key property
        public Status Status { get; set; } //Navigation property
    }
}
