using Newtonsoft.Json;

namespace StreamingOptionsAPI.DTO
{
    public class VerticalPosterDTO
    {
        [JsonProperty("w240")]
        public string? W240 { get; set; }

        [JsonProperty("w360")]
        public string? W360 { get; set; }

        [JsonProperty("w480")]
        public string? W480 { get; set; }

        [JsonProperty("w600")]
        public string? W600 { get; set; }

        [JsonProperty("w720")]
        public string? W720 { get; set; }
    }
}
