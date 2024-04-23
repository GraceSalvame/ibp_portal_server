using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ibp_portal_server.Model
{
    public class Payment_transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int payment_id { get; set; } //Foreign key property
        public Payment Payment { get; set; } //Navigation property

        public int user_id { get; set; } //Foreign key property
        public User User { get; set; } //Navigation property

        public int Role_id { get; set; } //Foreign key property
        public Role Role { get; set; } //Navigation property

        public int status_id { get; set; } //Foreign key property
        public Status Status { get; set; } //Navigation property

        public DateTime date_confirmed { get; set; }
    }
}
