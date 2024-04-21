using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        public DateTime CreatedAt { get; set; }

        // Navigation property
        public ICollection<Order>? Orders { get; set; }

        // Constructor to initialize non-nullable properties
        public User()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            CreatedAt = DateTime.UtcNow;
        }
    }
}
