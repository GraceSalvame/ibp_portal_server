using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ibp_portal_server.Model
{
    public class Government_id
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string name { get; set; }

        [Column(TypeName = "text")]
        public string description { get; set; }
    }
}
