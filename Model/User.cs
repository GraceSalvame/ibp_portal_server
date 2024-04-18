using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;

namespace ibp_portal_server.Model
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public int? user_id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string email { get; set; }

        [ForeignKey("Role")]
        public int role_id { get; set; }
        public Role Role { get; set; }

        [ForeignKey("branch_id")]
        public int? branch_id { get; set; }
        public Branch Branch { get; set; }

        [ForeignKey("Status")]
        public int status_id { get; set; }
        public Status Status { get; set; }

        [Required]
        public DateTime date_created { get; set; }
    }
}
