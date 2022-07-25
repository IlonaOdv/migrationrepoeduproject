namespace Eshop.BLL.DTOs
{
    public record GoodsDTO
    {
        public string Name { get; set; }
        public byte[] Photo { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string Currency { get; set; }
    }
}