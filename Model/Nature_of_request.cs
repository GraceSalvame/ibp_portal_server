using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ibp_portal_server.Model
{
    public class Nature_of_request
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(255)")]
        public string name { get; set; }

        [Column(TypeName = "ntext")]
        public string description { get; set; }

        //Navigation property
        public ICollection<Request> Requests { get; set; }
        public ICollection<Request_specification> Request_specifications { get; set; }
    }
}
