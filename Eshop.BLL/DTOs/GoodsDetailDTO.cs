using Eshop.DAL.Entities;

namespace Eshop.BLL.DTOs
{
    public record GoodsDetailDTO
    {
        public string Name { get; set; }
        public byte[] Photo { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }
        public int AvailableItems { get; set; }
        public CategoryEntity Category { get; set; }
        public ProducerEntity Producer { get; set; }
        public List<RatingEntity> Ratings { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string Currency { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}