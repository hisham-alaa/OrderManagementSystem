namespace OMS.Core.Models
{
    public class OrderItem : EntityBase
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        // Other properties or methods related to order items
    }
}