using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ibp_portal_server.Model
{
    public class User_log
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public int reference_id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string reference_type { get; set; }

        [Required]
        public DateTime date_signed_in { get; set; }

        public DateTime? date_signed_out { get; set; }
    }
}
