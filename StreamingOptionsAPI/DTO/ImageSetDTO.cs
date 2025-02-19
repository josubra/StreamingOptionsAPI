namespace StreamingOptionsAPI.DTO
{
    public class ImageSetDTO
    {
        public VerticalPosterDTO? VerticalPoster { get; set; }
        public HorizontalPosterDTO? HorizontalPoster { get; set; }
        public VerticalBackdropDTO? VerticalBackdrop { get; set; }
        public HorizontalBackdropDTO? HorizontalBackdrop { get; set; }
        public string? LightThemeImage { get; set; }
        public string? DarkThemeImage { get; set; }
        public string? WhiteImage { get; set; }
    }
}
