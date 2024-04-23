using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ibp_portal_server.Model
{
    public class Request_specification
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string name { get; set; }

        [Column(TypeName = "ntext")]
        public string description { get; set; }

        public int nature_of_request_id { get; set; } //Foreign key property
        public Nature_of_request Nature_of_request { get; set; } //Navigation property

        //Navigation property
        public ICollection<Request> Requests { get; set; }
        public ICollection<Request_sub_specification> request_sub_specifications { get; set; }
    }
}
