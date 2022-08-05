namespace Eshop.BLL.DTOs
{
    public record class RatingDetailDTO
    {
        public string Rater { get; set; }
        public DateTime RatingTime { get; set; }
        public int NumericRating { get; set; }
        public string TextRating { get; set; }
    }
}