using Newtonsoft.Json;
using StreamingOptionsAPI.DTO;

namespace StreamingOptionsAPI.VideoModel
{
    public class BrViewModel
    {
        public ServiceViewModel? Service { get; set; }
        public string? Type { get; set; }
        public string? Link { get; set; }
        public string? Quality { get; set; }
        public List<AudioViewModel> Audios { get; set; }
        public List<SubtitleViewModel> Subtitles { get; set; }
        public PriceViewModel Price { get; set; }
        public bool ExpiresSoon { get; set; }
        public int AvailableSince { get; set; }
        public AddonViewModel? Addon { get; set; }
        public string? VideoLink { get; set; }
        public int? ExpiresOn { get; set; }

        public BrViewModel()
        {
            Audios = new List<AudioViewModel>();
            Subtitles = new List<SubtitleViewModel>();
            Price = new PriceViewModel();

        }
    }
}
