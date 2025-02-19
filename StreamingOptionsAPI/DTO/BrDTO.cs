namespace StreamingOptionsAPI.DTO
{
    public class BrDTO
    {
        public ServiceDTO? Service { get; set; }
        public string? Type { get; set; }
        public string? Link { get; set; }
        public string? Quality { get; set; }
        public List<AudioDTO> Audios { get; set; }
        public List<SubtitleDTO> Subtitles { get; set; }
        public PriceDTO Price { get; set; }
        public bool ExpiresSoon { get; set; }
        public int AvailableSince { get; set; }
        public AddonDTO? Addon { get; set; }
        public string? VideoLink { get; set; }
        public int? ExpiresOn { get; set; }

        public BrDTO()
        {
            Audios = new List<AudioDTO>();
            Subtitles = new List<SubtitleDTO>();
            Price = new PriceDTO();

        }
    }
}
