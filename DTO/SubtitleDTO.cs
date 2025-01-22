using Newtonsoft.Json;

namespace StreamingOptionsAPI.DTO
{
    public class SubtitleDTO
    {
        [JsonProperty("closedCaptions")]
        public bool ClosedCaptions { get; set; }

        [JsonProperty("locale")]
        public LocaleDTO? Locale { get; set; }
    }
}
