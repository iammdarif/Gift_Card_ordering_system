using System.ComponentModel.DataAnnotations;

namespace GiftCardWebAPI.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;
       
        public string PhysicalAddress { get; set; } = string.Empty;
    }
}
