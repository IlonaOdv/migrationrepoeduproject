namespace Eshop.BLL.DTOs
{
    public record CreateRatingDTO
    {
        public string Rater { get; init; }
        public DateTime RatingTime { get; init; }
        public int NumericRating { get; init; }
        public string TextRating { get; init; }
    }
}