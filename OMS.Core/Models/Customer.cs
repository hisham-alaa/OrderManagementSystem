namespace OMS.Core.Models
{
    public class Customer : EntityBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        // Other properties or methods related to customers
        public List<Order> Orders { get; set; }

    }
}
