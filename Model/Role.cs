using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ibp_portal_server.Model
{
    public class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string name { get; set; }

        [Column(TypeName = "ntext")]
        public string description { get; set; }

        //Navigation property
        public ICollection<Ibp_registration> Ibp_registrations { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Payment_transaction> Payment_transactions { get; set; }
        public ICollection<Request_transaction> Request_transactions { get; set; }
    }
}
