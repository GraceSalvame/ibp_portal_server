using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ibp_portal_server.Model
{
    public class Lost_cash_card_fund_transfer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int request_id { get; set; } //Foreign key property
        public Request Request { get; set; } //Navigation property

        [Required]
        [Column(TypeName = "nvarchar(30)")]
        public string prev_cash_card_no { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string prev_cash_card_account_no { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(30)")]
        public string new_cash_card_no { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string new_cash_card_account_no { get; set; }
    }
}
