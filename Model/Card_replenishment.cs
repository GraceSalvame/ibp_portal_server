using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ibp_portal_server.Model
{
    public class Card_replenishment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int request_id { get; set; } //Foreign key property
        public Request Request { get; set; } //Navigation property

        [Required]
        public int quantity { get; set; }
    }
}
