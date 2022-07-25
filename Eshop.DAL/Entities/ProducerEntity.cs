namespace Eshop.DAL.Entities
{
    public class ProducerEntity : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public string Country { get; set; }
        public string ProductList { get; set; }
    }
}