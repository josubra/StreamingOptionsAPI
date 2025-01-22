using Newtonsoft.Json;

namespace StreamingOptionsAPI.DTO
{
    public class MovieStreamResponseDTO
    {
        [JsonProperty("itemType")]
        public string? ItemType { get; set; }

        [JsonProperty("showType")]
        public string? ShowType { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("imdbId")]
        public required string ImdbId { get; set; }

        [JsonProperty("tmdbId")]
        public string? TmdbId { get; set; }

        [JsonProperty("title")]
        public required string Title { get; set; }

        [JsonProperty("overview")]
        public string? Overview { get; set; }

        [JsonProperty("releaseYear")]
        public int ReleaseYear { get; set; }

        [JsonProperty("originalTitle")]
        public string? OriginalTitle { get; set; }

        [JsonProperty("genres")]
        public List<GenreDTO>? Genres { get; set; }

        [JsonProperty("directors")]
        public List<string>? Directors { get; set; }

        [JsonProperty("cast")]
        public List<string>? Cast { get; set; }

        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("runtime")]
        public int Runtime { get; set; }

        [JsonProperty("imageSet")]
        public ImageSetDTO? ImageSet { get; set; }

        [JsonProperty("streamingOptions")]
        public StreamingOptionsDTO? StreamingOptions { get; set; }
    }
}
