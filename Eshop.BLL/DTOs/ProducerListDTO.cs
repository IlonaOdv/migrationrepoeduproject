namespace Eshop.BLL.DTOs
{
    public record class ProducerListDTO
    {
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public string Country { get; set; }
    }
}