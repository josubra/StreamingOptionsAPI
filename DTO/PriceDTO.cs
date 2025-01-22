using Newtonsoft.Json;

namespace StreamingOptionsAPI.DTO
{
    public class PriceDTO
    {
        [JsonProperty("amount")]
        public string? Amount { get; set; }

        [JsonProperty("currency")]
        public string? Currency { get; set; }

        [JsonProperty("formatted")]
        public string? Formatted { get; set; }
    }
}
