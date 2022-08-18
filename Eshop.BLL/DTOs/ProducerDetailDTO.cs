namespace Eshop.BLL.DTOs
{
    public record ProducerDetailDTO
    {
        public int ID { get; init; }
        public string Name { get; init; }
        public string Description { get; init; }
        public byte[] Image { get; init; }
        public string Country { get; init; }
        public string ProductList { get; init; }
    }
}