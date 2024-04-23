using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ibp_portal_server.Model
{
    public class Employment_sector
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string name { get; set; }

        //Navigation Property
        public ICollection<Ibp> Ibps { get; set; }
        public ICollection<Ibp_information_update> Ibp_information_updates { get; set; }
    }
}
