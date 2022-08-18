namespace Eshop.BLL.DTOs
{
    public record ProducerListDTO
    {
        public int ID { get; init; }
        public string Name { get; init; }
        public byte[] Image { get; init; }
        public string Country { get; init; }
    }
}