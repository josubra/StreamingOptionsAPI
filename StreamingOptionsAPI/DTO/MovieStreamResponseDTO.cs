namespace StreamingOptionsAPI.DTO
{
    public class MovieStreamResponseDTO
    {
        public string? ItemType { get; set; }
        public string? ShowType { get; set; }
        public string? Id { get; set; }
        public string? ImdbId { get; set; }
        public string? TmdbId { get; set; }
        public string? Title { get; set; }
        public string? Overview { get; set; }
        public int ReleaseYear { get; set; }
        public string? OriginalTitle { get; set; }
        public List<GenreDTO>? Genres { get; set; }
        public List<string>? Directors { get; set; }
        public List<string>? Cast { get; set; }
        public int Rating { get; set; }
        public int Runtime { get; set; }
        public ImageSetDTO? ImageSet { get; set; }
        public StreamingOptionsDTO? StreamingOptions { get; set; }
    }
}
