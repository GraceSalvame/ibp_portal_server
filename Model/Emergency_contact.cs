using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ibp_portal_server.Model
{
    public class Emergency_contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int ibp_id { get; set; } //Foreign key property
        public Ibp Ibp { get; set; } //Navigation property

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string name { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string relationship { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(11)")]
        public string contact_no { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string email { get; set; }
    }
}
