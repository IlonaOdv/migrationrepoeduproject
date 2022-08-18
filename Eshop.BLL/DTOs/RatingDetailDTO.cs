namespace Eshop.BLL.DTOs
{
    public record RatingDetailDTO
    {
        public int ID { get; init; }
        public string Rater { get; init; }
        public DateTime RatingTime { get; init; }
        public int NumericRating { get; init; }
        public string TextRating { get; init; }
    }
}