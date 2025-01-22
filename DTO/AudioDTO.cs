using Newtonsoft.Json;

namespace StreamingOptionsAPI.DTO
{
    public class AudioDTO
    {
        [JsonProperty("language")]
        public string? Language { get; set; }

        [JsonProperty("region")]
        public string? Region { get; set; }
    }
}
