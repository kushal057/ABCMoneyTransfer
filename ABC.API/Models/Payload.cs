namespace ABC.API.Models
{
    public class Payload
    {
        public string Date { get; set; }
        public string PublishedOn { get; set; }
        public string ModifiedOn { get; set; }
        public List<Rate> Rates { get; set; }
    }
}
