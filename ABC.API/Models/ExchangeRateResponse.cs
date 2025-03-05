using System.Text.Json.Serialization;

namespace ABC.API.Models
{
    public class ExchangeRateResponse
    {
        [JsonPropertyName("status")]
        public Status Status { get; set; }

        [JsonPropertyName("errors")]
        public Errors Errors { get; set; }

        [JsonPropertyName("params")]
        public Params Params { get; set; }

        [JsonPropertyName("data")]
        public ExchangeRateData Data { get; set; }  

        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; }
    }

    public class ExchangeRateData
    {
        [JsonPropertyName("payload")]
        public List<Payload> Payload { get; set; } = new List<Payload>(); 
    }

    public class Payload
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("published_on")]
        public string PublishedOn { get; set; }

        [JsonPropertyName("modified_on")]
        public string ModifiedOn { get; set; }

        [JsonPropertyName("rates")]
        public List<Rate> Rates { get; set; } = new List<Rate>();
    }

    public class Rate
    {
        [JsonPropertyName("currency")]
        public Currency Currency { get; set; }

        [JsonPropertyName("buy")]
        public string Buy { get; set; }

        [JsonPropertyName("sell")]
        public string Sell { get; set; }
    }

    public class Currency
    {
        [JsonPropertyName("iso3")]
        public string Iso3 { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("unit")]
        public int Unit { get; set; }
    }

    public class Status
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }
    }

    public class Errors
    {
        [JsonPropertyName("validation")]
        public object Validation { get; set; }
    }

    public class Params
    {
        [JsonPropertyName("from")]
        public string From { get; set; }

        [JsonPropertyName("to")]
        public string To { get; set; }

        [JsonPropertyName("per_page")]
        public string PerPage { get; set; }

        [JsonPropertyName("page")]
        public string Page { get; set; }

    }

    public class Links
    {
        [JsonPropertyName("prev")]
        public string Prev { get; set; }

        [JsonPropertyName("next")]
        public string Next { get; set; }
    }

    public class Pagination
    {
        [JsonPropertyName("page")]
        public int Page { get; set; }

        [JsonPropertyName("pages")]
        public int Pages { get; set; }

        [JsonPropertyName("per_page")]
        public int PerPage { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }
}
