namespace ABC.API.Models
{
    public class Rate
    {
        public Currency Currency { get; set; }
        public decimal? Buy { get; set; }
        public decimal? Sell { get; set; }
    }
}
