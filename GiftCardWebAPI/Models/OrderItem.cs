namespace GiftCardWebAPI.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int GiftCardId { get; set; }

        public GiftCard GiftCard { get; set; }

        public int Quantity { get; set; }
    }
}
