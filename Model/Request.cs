using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ibp_portal_server.Model
{
    public class Request
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int ibp_id { get; set; } //Foreign key property
        public Ibp Ibp { get; set; } //Navigation property

        public int branch_id { get; set; } //Foreign key property
        public Branch Branch { get; set; }  //Navigation property

        public int nature_of_request_id { get; set; } //Foreign key property
        public Nature_of_request Nature_of_request { get; set; } //Navigation property

        public int request_specification_id { get; set; } //Foreign key property
        public Request_specification Request_specification { get; set; } //Navigation property

        public int request_sub_specification_id { get; set; } //Foreign key property
        public Request_sub_specification Request_sub_specification { get; set; } //Navigation property

        [Required]
        public int reference_id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string reference_type { get; set; }

        public int status_id { get; set; } //Foreign key property
        public Status Status { get; set; }  //Navigation property

        [Required]
        public DateTime date_created { get; set; }

        //Navigation property
        public ICollection<Card_replenishment> Card_replenishments { get; set; }
        public ICollection<Ibp_information_update> Ibp_information_updates { get; set; }
        public ICollection<Lost_cash_card_deactivation> Lost_cash_card_deactivations { get; set; }
        public ICollection<Lost_cash_card_fund_transfer> Lost_cash_card_fund_transfers { get; set; }
        public ICollection<Lost_cash_card_replacement> Lost_cash_card_replacements { get; set; }
        public ICollection<Mailer_pin> Mailer_pins { get; set; }
        public ICollection<Payout_related_concern> Payout_related_concerns { get; set; }
        public ICollection<Request_transaction> Request_transactions { get; set; }
    }
}
