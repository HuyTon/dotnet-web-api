using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Demo.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string? OrderNumber { get; set; }

        // Foreign key
        [ForeignKey("UserId")]
        public int UserId { get; set; }

        // Navigation property
        [JsonIgnore] // Ignore serialization of the User property
        public User? User { get; set; }
    }
}
