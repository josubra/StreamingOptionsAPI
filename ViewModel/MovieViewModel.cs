using Newtonsoft.Json;
using StreamingOptionsAPI.DTO;

namespace StreamingOptionsAPI.Model
{
    public class MovieViewModel
    {
        public string? ItemType { get; set; }
        public string? ShowType { get; set; }
        public required string Id { get; set; }
        public required string ImdbId { get; set; }
        public string? TmdbId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? ReleaseYear { get; set; }
        List<GenreDTO>? Genres { get; set; }
        public ImageSetDTO? ImageSet { get; set; }
        public StreamingOptionsDTO? StreamingOptions { get; set; }
    }
}
