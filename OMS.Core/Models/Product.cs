namespace OMS.Core.Models
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
