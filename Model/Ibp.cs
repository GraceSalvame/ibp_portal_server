using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;

namespace ibp_portal_server.Model
{
    public class Ibp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string user_id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string firstname { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string middle_name { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string lastname { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string suffix { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string contact_no { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string email { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string password { get; set; }

        [Column(TypeName = "varchar(11)")]
        public string tin_no { get; set; }

        [Required]
        [Column(TypeName = "varchar(6)")]
        public string gender { get; set; }

        [Required]
        public DateTime birthdate { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string civil_status { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string employment_status { get; set; }

        [Required]
        [Column(TypeName = "varchar100)")]
        public string occupation_business { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string recruiter_sponsor { get; set; }

        public DateTime? requirements_due_date { get; set; }

        [Column(TypeName = "image")]
        public byte[] attachment_profile_id { get; set; }

        [Column(TypeName = "image")]
        public byte[] attachment_government_id { get; set; }

        [Column(TypeName = "image")]
        public byte[] attachment_government_selfie_id { get; set; }

        [Column(TypeName = "image")]
        public byte[] attachment_personal_id { get; set; }

        [Column(TypeName = "image")]
        public byte[] attachment_signature_id { get; set; }

        [Column(TypeName = "image")]
        public byte[] attachment_gcash_id { get; set; }

        [ForeignKey("Ibp_type")]
        public int ibp_type_id { get; set; }
        public Ibp_type Ibp_type { get; set; }

        [ForeignKey("Branch")]
        public int branch_id { get; set; }
        public Branch Branch { get; set; }

        [ForeignKey("Government_id")]
        public int? government_id { get; set; }
        public Government_id Government_id { get; set; }

        [ForeignKey("Recruitment_channel")]
        public int? recruitment_channel_id { get; set; }
        public Recruitment_channel Recruitment_channel { get; set; }

        [ForeignKey("Employment_sector")]
        public int? employment_sector_id { get; set; }
        public Employment_sector Employment_sector { get; set; }

        [ForeignKey("Status")]
        public int? status_id { get; set; }
        public Status Status { get; set; }

        public DateTime? date_created { get; set; }
    }
}
