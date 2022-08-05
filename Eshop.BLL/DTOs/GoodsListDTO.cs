using Eshop.DAL.Entities;

namespace Eshop.BLL.DTOs
{
    public record class GoodsListDTO
    {
        public string Name { get; set; }
        public byte[] Photo { get; set; }
        public double Price { get; set; }
        public CategoryEntity Category { get; set; }
        public string Currency { get; set; }
    }
}