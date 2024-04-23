using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ibp_portal_server.Model
{
    public class Request_transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int request_id { get; set; } //Foreign key property
        public Request Request { get; set; } //Navigation property

        public int user_id { get; set; } //Foreign key property
        public User User { get; set; } //Navigation property

        public int role_id { get; set; } //Foreign key property
        public Role Role { get; set; } //Navigation property

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string subject { get; set; }

        [Required]
        [Column(TypeName = "ntext")]
        public string remarks { get; set; }

        public int status_id { get; set; } //Foreign key property
        public Status Status { get; set; } //Navigation property

        public DateTime date_created { get; set; }
    }
}
