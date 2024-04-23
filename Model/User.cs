using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;

namespace ibp_portal_server.Model
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public int? user_id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string email { get; set; }

        public int role_id { get; set; } //Foreign key property
        public Role Role { get; set; } //Navigation property

        public int branch_id { get; set; } //Foreign key property
        public Branch Branch { get; set; } //Navigation property

        public int status_id { get; set; } //Foreign key property
        public Status Status { get; set; } //Navigation property

        [Required]
        public DateTime date_created { get; set; }

        //Navigation property
        public ICollection<Ibp_registration> Ibp_registrations { get; set; }
        public ICollection<Payment_transaction> Payment_transactions { get; set; }
        public ICollection<Request_transaction> Request_transactions { get; set; }
    }
}
