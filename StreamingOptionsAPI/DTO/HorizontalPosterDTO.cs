using Newtonsoft.Json;

namespace StreamingOptionsAPI.DTO
{
    public class HorizontalPosterDTO
    {
        [JsonProperty("w360")]
        public string? W360 { get; set; }

        [JsonProperty("w480")]
        public string? W480 { get; set; }

        [JsonProperty("w720")]
        public string? W720 { get; set; }

        [JsonProperty("w1080")]
        public string? W1080 { get; set; }

        [JsonProperty("w1440")]
        public string? W1440 { get; set; }
    }
}
