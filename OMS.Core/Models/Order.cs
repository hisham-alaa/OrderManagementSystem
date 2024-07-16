namespace OMS.Core.Models
{
    public class Order : EntityBase
    {
        public Guid CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public OrderStatus Status { get; set; }
        // Other properties or methods related to orders
    }
}
