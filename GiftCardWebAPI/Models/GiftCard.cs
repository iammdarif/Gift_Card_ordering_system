using System.ComponentModel.DataAnnotations;

namespace GiftCardWebAPI.Models
{
    public class GiftCard
    {
        public int Id { get; set; }

        [Required]
        [Range(10,200)]
        public int FaceValue { get; set; }

        public string? Message { get; set; } = string.Empty;

        public double TotalCost { get => FaceValue + 2.95; }

    }
}
