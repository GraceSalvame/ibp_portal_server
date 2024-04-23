using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ibp_portal_server.Model
{
    public class Notification
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string subject { get; set; }

        [Required]
        [Column(TypeName = "ntext")]
        public string content { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string notification_type { get; set; }

        [Required]
        public int origin_id { get; set; }

        [Required]
        public int destination_id { get; set; }

        [Required]
        public DateTime date_created { get; set; }
    }
}
