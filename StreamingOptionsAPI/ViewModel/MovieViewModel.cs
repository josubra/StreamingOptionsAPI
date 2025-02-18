using Newtonsoft.Json;
using StreamingOptionsAPI.DTO;
using StreamingOptionsAPI.VideoModel;

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
        public string Overview { get; set; } = string.Empty;
        public List<GenreViewModel>? Genres { get; set; }
        public ImageSetViewModel? ImageSet { get; set; }
        public StreamingOptionsViewModel? StreamingOptions { get; set; }
    }
}
