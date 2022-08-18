using Eshop.DAL.Entities;

namespace Eshop.BLL.DTOs
{
    public record CreateGoodsDTO
    {
        public string Name { get; init; }
        public byte[] Photo { get; init; }
        public string Description { get; init; }
        public double Price { get; init; }
        public double Weight { get; init; }
        public int AvailableItems { get; init; }
        public CategoryEntity Category { get; init; }
        public ProducerEntity Producer { get; init; }
        public List<RatingEntity> Ratings { get; init; }
        public string Size { get; init; }
        public string Color { get; init; }
        public string Currency { get; init; }
        public DateTime DeliveryDate { get; init; }
    }
}