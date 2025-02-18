using Newtonsoft.Json;

namespace StreamingOptionsAPI.VideoModel
{
    public class PriceViewModel
    {
        public string? Amount { get; set; }
        public string? Currency { get; set; }
        public string? Formatted { get; set; }
    }
}
