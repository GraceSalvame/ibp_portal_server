using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace ibp_portal_server.Model
{
    public class Ibp_registration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Ibp")]
        public int ibp_id { get; set; }
        public Ibp Ibp { get; set; }

        [ForeignKey("User")]
        public int user_id { get; set; }
        public User User { get; set; }

        [ForeignKey("Role")]
        public int role_id { get; set; }
        public Role Role { get; set; }

        public DateTime confirmed_date { get; set; }
    }
}
