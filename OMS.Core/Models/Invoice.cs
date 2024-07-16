namespace OMS.Core.Models
{
    public class Invoice : EntityBase
    {
        public Guid OrderId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal TotalAmount { get; set; }
        // Other properties or methods related to invoices
    }
}
