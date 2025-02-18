using Newtonsoft.Json;

namespace StreamingOptionsAPI.DTO
{
    public class GenreDTO
    {
        [JsonProperty("id")]
        public required string Id { get; set; }

        [JsonProperty("name")]
        public required string Name { get; set; }
    }
}
