using Newtonsoft.Json;

namespace StreamingOptionsAPI.DTO
{
    public class AddonDTO
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("homePage")]
        public string? HomePage { get; set; }

        [JsonProperty("themeColorCode")]
        public string? ThemeColorCode { get; set; }

        [JsonProperty("imageSet")]
        public ImageSetDTO? ImageSet { get; set; }
    }
}
