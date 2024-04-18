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

        [ForeignKey("user_id")]
        public User User { get; set; }

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

        public int ibp_type_id { get; set; }
        [ForeignKey("ibp_type_id")]
        public Ibp_type Ibp_type { get; set; }

        public int branch_id { get; set; }
        [ForeignKey("branch_id")]
        public Branch Branch { get; set; }

        public int? government_id { get; set; }
        [ForeignKey("government_id")]
        public Government_Id Government_Id { get; set; }

        public int? recruitment_channel_id { get; set; }
        [ForeignKey("recruitment_channel_id")]
        public Recruitment_channel Recruitment_channel { get; set; }

        public int? employment_sector_id { get; set; }
        [ForeignKey("employment_sector_id")]
        public Employment_sector Employment_sector { get; set; }

        [DefaultValue(0)]
        public int? status_id { get; set; }
        [ForeignKey("status_id")]
        public Status Status { get; set; }

        public DateTime? date_created { get; set; }
    }
}
