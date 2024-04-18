using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ibp_portal_server.Model
{
    public class Corporate_affiliate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [ForeignKey("Ibp")]
        public int ibp_id { get; set; }
        public Ibp Ibp { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string name { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string relationship { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string position { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string rank { get; set; }
    }
}
