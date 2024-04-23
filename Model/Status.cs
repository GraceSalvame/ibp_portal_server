using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ibp_portal_server.Model
{
    public class Status
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string code { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string name { get; set; }

        [Column(TypeName = "ntext")]
        public string description { get; set; }

        //Navigation Property
        public ICollection<Account_status> Account_statuses { get; set; }
        public ICollection<Ibp> Ibps { get; set; }
        public ICollection<Payment_method> Payment_methods { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Payment_detail> Payment_details { get; set; }
        public ICollection<Payment_transaction> Payment_transactions { get; set; }
        public ICollection<Request> Requests { get; set; }
        public ICollection<Request_transaction> Request_transactions { get; set; }
    }
}
