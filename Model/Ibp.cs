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
        [Column(TypeName = "nvarchar(50)")]
        public string user_id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string firstname { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string middle_name { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string lastname { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string suffix { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(11)")]
        public string contact_no { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string email { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(25)")]
        public string password { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        public string tin_no { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(6)")]
        public string gender { get; set; }

        [Required]
        public DateTime birthdate { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string civil_status { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string employment_status { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string occupation_business { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string recruiter_sponsor { get; set; }

        public DateTime requirements_due_date { get; set; }

        [Column(TypeName = "image")]
        public byte[] attachment_profile_id { get; set; }

        [Column(TypeName = "image")]
        public byte[] attachment_government_id { get; set; }

        [Column(TypeName = "image")]
        public byte[] attachment_government_selfie_id { get; set; }

        [Required]
        [Column(TypeName = "image")]
        public byte[] attachment_personal_id { get; set; }

        [Required]
        [Column(TypeName = "image")]
        public byte[] attachment_signature_id { get; set; }

        [Column(TypeName = "image")]
        public byte[] attachment_gcash_id { get; set; }

        public int ibp_type_id { get; set; } //Foreign key property
        public Ibp_type Ibp_type { get; set; } //Navigation property

        public int branch_id { get; set; } //Foreign key property
        public Branch Branch { get; set; }  //Navigation property

        public int government_id { get; set; } //Foreign key property
        public Government_id Government_id { get; set; } //Navigation property

        public int recruitment_channel_id { get; set; } //Foreign key property
        public Recruitment_channel Recruitment_channel { get; set; } //Navigation property

        public int employment_sector_id { get; set; } //Foreign key property
        public Employment_sector Employment_sector { get; set; } //Navigation property

        public int status_id { get; set; } //Foreign key property
        public Status Status { get; set; } //Navigation property

        [Required]
        public DateTime date_created { get; set; }

        //Navigation Property
        public ICollection<Corporate_affiliate> Corporate_affiliates { get; set; }
        public ICollection<Emergency_contact> Emergency_contacts { get; set; }
        public ICollection<Ibp_registration> Ibp_registrations { get; set; }
        public ICollection<Payment_method> Payment_methods { get; set; }
        public ICollection<Payment_detail> Payment_details { get; set; }
        public ICollection<Request> Requests { get; set; }
    }
}
