namespace StreamingOptionsAPI.ViewModel
{
    public class MovieViewModel
    {
        public string? ItemType { get; set; }
        public string? ShowType { get; set; }
        public string? Id { get; set; }
        public string? ImdbId { get; set; }
        public string? TmdbId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? ReleaseYear { get; set; }
        public string Overview { get; set; } = string.Empty;
        public List<GenreViewModel>? Genres { get; set; }
        public ImageSetViewModel? ImageSet { get; set; }
        public StreamingOptionsViewModel? StreamingOptions { get; set; }
    }
}
