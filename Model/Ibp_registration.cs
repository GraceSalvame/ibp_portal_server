using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ibp_portal_server.Model
{
    public class Ibp_registration
    {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int id { get; set; }

            public int ibp_id { get; set; } //Foreign key property
            public Ibp Ibp { get; set; } //Navigation property

            public int user_id { get; set; } //Foreign key property
            public User User { get; set; } //Navigation property

            public int role_id { get; set; } //Foreign key property
            public Role Role { get; set; } //Navigation property

            [Required]
            public DateTime confirmed_date { get; set; }
        }
    }
