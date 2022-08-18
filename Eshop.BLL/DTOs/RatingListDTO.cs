namespace Eshop.BLL.DTOs
{
    public record RatingListDTO
    {
        public int ID { get; init; }
        public int NumericRating { get; init; }
    }
}