using Newtonsoft.Json;
using StreamingOptionsAPI.DTO;

namespace StreamingOptionsAPI.VideoModel
{
    public class ServiceViewModel
    {
        public required string Id { get; set; }
        public required string Name { get; set; }
        public string? HomePage { get; set; }
        public string? ThemeColorCode { get; set; }
        public ImageSetViewModel? ImageSet { get; set; }
    }
}
