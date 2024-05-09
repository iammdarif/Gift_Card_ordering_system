using System.ComponentModel.DataAnnotations;

namespace GiftCardWebAPI.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public int PersonId { get; set; }

        public Person Person { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public string DeliveryAddress { get; set; }

        public int DeliveryId { get; set; }
        public Delivery Delivery { get; set; }


        public double TotalCost { get; set; }

        public IEnumerable<OrderItem> OrderItems { get; set; }


    }
}
