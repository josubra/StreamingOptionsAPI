using Newtonsoft.Json;

namespace StreamingOptionsAPI.VideoModel
{
    public class LocaleViewModel
    {
        public required string Language { get; set; }
        public required string Region { get; set; }
    }
}
