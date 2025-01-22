using Newtonsoft.Json;
using StreamingOptionsAPI.DTO;

namespace StreamingOptionsAPI.VideoModel
{
    public class SubtitleViewModel
    {
        public bool ClosedCaptions { get; set; }
        public LocaleViewModel? Locale { get; set; }
    }
}
