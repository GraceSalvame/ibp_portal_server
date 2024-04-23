using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ibp_portal_server.Model
{
    public class Activity_log
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
        [Column(TypeName = "nvarchar(255)")]
        public string title { get; set; }

        [Required]
        [Column(TypeName = "ntext")]
        public string description { get; set; }

        [Required]
        public DateTime date_created { get; set; }
    }
}
