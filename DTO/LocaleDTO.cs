using Newtonsoft.Json;

namespace StreamingOptionsAPI.DTO
{
    public class LocaleDTO
    {
        [JsonProperty("language")]
        public required string Language { get; set; }

        [JsonProperty("region")]
        public required string Region { get; set; }
    }
}
