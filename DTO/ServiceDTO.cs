using Newtonsoft.Json;

namespace StreamingOptionsAPI.DTO
{
    public class ServiceDTO
    {
        [JsonProperty("id")]
        public required string Id { get; set; }

        [JsonProperty("name")]
        public required string Name { get; set; }

        [JsonProperty("homePage")]
        public string? HomePage { get; set; }

        [JsonProperty("themeColorCode")]
        public string? ThemeColorCode { get; set; }

        [JsonProperty("imageSet")]
        public ImageSetDTO? ImageSet { get; set; }
    }
}
