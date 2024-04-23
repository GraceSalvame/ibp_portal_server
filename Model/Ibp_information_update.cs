using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ibp_portal_server.Model
{
    public class Ibp_information_update
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int request_id { get; set; } //Foreign key property
        public Request Request { get; set; } //Navigation property

        [Column(TypeName = "nvarchar(50)")]
        public string prev_firstname { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string prev_middle_name { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string prev_lastname { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string prev_suffix { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        public string prev_contact_no { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string prev_email { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string prev_password { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        public string prev_tin_no { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(6)")]
        public string prev_gender { get; set; }

        [Required]
        public DateTime prev_birthdate { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string prev_civil_status { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string prev_employment_status { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string prev_occupation_business { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string prev_recruiter_sponsor { get; set; }

        public DateTime prev_requirements_due_date { get; set; }

        [Column(TypeName = "image")]
        public byte[] prev_attachment_profile_id { get; set; }

        [Column(TypeName = "image")]
        public byte[] prev_attachment_government_id { get; set; }

        [Column(TypeName = "image")]
        public byte[] prev_attachment_government_selfie_id { get; set; }

        [Required]
        [Column(TypeName = "image")]
        public byte[] prev_attachment_personal_id { get; set; }

        [Required]
        [Column(TypeName = "image")]
        public byte[] prev_attachment_signature_id { get; set; }

        [Column(TypeName = "image")]
        public byte[] prev_attachment_gcash_id { get; set; }

        public int prev_ibp_type_id { get; set; } //Foreign key property
        public Ibp_type Ibp_type { get; set; } //Navigation property

        public int prev_branch_id { get; set; } //Foreign key property
        public Branch Branch { get; set; }  //Navigation property

        public int prev_government_id { get; set; } //Foreign key property
        public Government_id Government_id { get; set; } //Navigation property

        public int prev_recruitment_channel_id { get; set; } //Foreign key property
        public Recruitment_channel Recruitment_channel { get; set; } //Navigation property

        public int prev_employment_sector_id { get; set; } //Foreign key property
        public Employment_sector Employment_sector { get; set; } //Navigation property
    }
}
