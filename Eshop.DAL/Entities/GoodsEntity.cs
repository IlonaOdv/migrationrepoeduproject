namespace Eshop.DAL.Entities
{
    public class GoodsEntity : EntityBase
    {
        public string Name { get; set; }
        public byte[] Photo { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }
        public int AvailableItems { get; set; }
        public string Category { get; set; }
        public string Producer { get; set; }
        public int Rating { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string Currency { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}