using Newtonsoft.Json;

namespace StreamingOptionsAPI.DTO
{
    public class StreamingOptionsDTO
    {
        [JsonProperty("br")]
        public List<BrDTO>? Br { get; set; }
    }
}
