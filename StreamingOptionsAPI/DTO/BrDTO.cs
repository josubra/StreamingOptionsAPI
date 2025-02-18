using Newtonsoft.Json;

namespace StreamingOptionsAPI.DTO
{
    public class BrDTO
    {
        [JsonProperty("service")]
        public ServiceDTO? Service { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("link")]
        public string? Link { get; set; }

        [JsonProperty("quality")]
        public string? Quality { get; set; }

        [JsonProperty("audios")]
        public List<AudioDTO> Audios { get; set; }

        [JsonProperty("subtitles")]
        public List<SubtitleDTO> Subtitles { get; set; }

        [JsonProperty("price")]
        public PriceDTO Price { get; set; }

        [JsonProperty("expiresSoon")]
        public bool ExpiresSoon { get; set; }

        [JsonProperty("availableSince")]
        public int AvailableSince { get; set; }

        [JsonProperty("addon")]
        public AddonDTO? Addon { get; set; }

        [JsonProperty("videoLink")]
        public string? VideoLink { get; set; }

        [JsonProperty("expiresOn")]
        public int? ExpiresOn { get; set; }

        public BrDTO()
        {
            Audios = new List<AudioDTO>();
            Subtitles = new List<SubtitleDTO>();
            Price = new PriceDTO();

        }
    }
}
