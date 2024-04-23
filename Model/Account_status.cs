using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ibp_portal_server.Model
{
    public class Account_status
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public int reference_id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string reference_type { get; set; }

        public int status_id { get; set; } //Foreign key property
        public Status Status { get; set; } //Navigation property

        [Required]
        public DateTime date_created { get; set; }
    }
}
