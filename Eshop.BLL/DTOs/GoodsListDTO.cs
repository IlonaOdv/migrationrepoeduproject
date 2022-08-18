using Eshop.DAL.Entities;

namespace Eshop.BLL.DTOs
{
    public record GoodsListDTO
    {
        public int ID { get; init; }
        public string Name { get; init; }
        public byte[] Photo { get; init; }
        public double Price { get; init; }
        public CategoryEntity Category { get; init; }
        public string Currency { get; init; }
    }
}