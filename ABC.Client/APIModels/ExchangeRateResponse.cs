using System.Text.Json.Serialization;

namespace ABC.Client.APIModels
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
        public List<Payload> Data { get; set; } = new List<Payload>();

        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; }
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

    public class Rate
    {
        [JsonPropertyName("currency")]
        public Currency Currency { get; set; }

        [JsonPropertyName("buy")]
        public string Buy { get; set; }

        [JsonPropertyName("sell")]
        public string Sell { get; set; }
    }

    public class Payload
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("publishedOn")]
        public string PublishedOn { get; set; }

        [JsonPropertyName("modifiedOn")]
        public string ModifiedOn { get; set; }

        [JsonPropertyName("rates")]
        public List<Rate> Rates { get; set; } = new List<Rate>();
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
        public DateTime From { get; set; }

        [JsonPropertyName("to")]
        public DateTime To { get; set; }

        [JsonPropertyName("skip")]
        public int Skip { get; set; }

        [JsonPropertyName("take")]
        public int Take { get; set; }
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

        [JsonPropertyName("perPage")]
        public int PerPage { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }
}
