namespace Eshop.DAL.Entities
{
    public class RatingEntity : EntityBase
    {
        public int NumericRating { get; set; }
        public string? TextRating { get; set; }
    }
}