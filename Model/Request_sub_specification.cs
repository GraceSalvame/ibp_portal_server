using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ibp_portal_server.Model
{
    public class Request_sub_specification
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string name { get; set; }

        [Column(TypeName = "ntext")]
        public string description { get; set; }

        public int request_specification_id { get; set; } //Foreign key property
        public Request_specification Request_specification { get; set; } //Navigation property

        //Navigation property
        public ICollection<Request> Requests { get; set; }
    }
}
