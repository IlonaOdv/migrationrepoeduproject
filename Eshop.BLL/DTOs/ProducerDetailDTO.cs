namespace Eshop.BLL.DTOs
{
    public record class ProducerDetailDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public string Country { get; set; }
        public string ProductList { get; set; }
    }
}