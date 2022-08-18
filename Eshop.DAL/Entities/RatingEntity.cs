namespace Eshop.DAL.Entities
{
    public class RatingEntity : EntityBase
    {
        public string Rater { get; set; }
        public DateTime RatingTime { get; set; }
        public int NumericRating { get; set; }
        public string TextRating { get; set; }
    }
}