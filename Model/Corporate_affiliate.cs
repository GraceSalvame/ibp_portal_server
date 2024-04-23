using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ibp_portal_server.Model
{
    public class Corporate_affiliate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int ibp_id { get; set; } //Foreign key property
        public Ibp Ibp { get; set; } //Navigation Property

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string name { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string relationship { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string position { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string rank { get; set; }
    }
}
