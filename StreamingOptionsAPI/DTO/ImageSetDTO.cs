using Newtonsoft.Json;

namespace StreamingOptionsAPI.DTO
{
    public class ImageSetDTO
    {
        [JsonProperty("verticalPoster")]
        public VerticalPosterDTO? VerticalPoster { get; set; }

        [JsonProperty("horizontalPoster")]
        public HorizontalPosterDTO? HorizontalPoster { get; set; }

        [JsonProperty("verticalBackdrop")]
        public VerticalBackdropDTO? VerticalBackdrop { get; set; }

        [JsonProperty("horizontalBackdrop")]
        public HorizontalBackdropDTO? HorizontalBackdrop { get; set; }

        [JsonProperty("lightThemeImage")]
        public string? LightThemeImage { get; set; }

        [JsonProperty("darkThemeImage")]
        public string? DarkThemeImage { get; set; }

        [JsonProperty("whiteImage")]
        public string? WhiteImage { get; set; }
    }
}
