using AutoMapper;
using StreamingOptionsAPI.DTO;
using StreamingOptionsAPI.Model;
using StreamingOptionsAPI.VideoModel;

namespace StreamingOptionsAPI.AutoMapper
{
    public class ConfigurationMapping : Profile
    {
        public ConfigurationMapping() 
        {
            CreateMap<MovieViewModel, MovieStreamResponseDTO>().ReverseMap();
            CreateMap<ImageSetViewModel, ImageSetDTO>().ReverseMap();
            CreateMap<VerticalPosterViewModel, VerticalPosterDTO>().ReverseMap();
            CreateMap<StreamingOptionsViewModel, StreamingOptionsDTO>().ReverseMap();
            CreateMap<BrViewModel, BrDTO>().ReverseMap();
            CreateMap<ServiceViewModel, ServiceDTO>().ReverseMap();
            CreateMap<AudioViewModel, AudioDTO>().ReverseMap();
            CreateMap<SubtitleViewModel, SubtitleDTO>().ReverseMap();
            CreateMap<LocaleViewModel, LocaleDTO>().ReverseMap();
            CreateMap<PriceViewModel, PriceDTO>().ReverseMap();
            CreateMap<AddonViewModel, AddonDTO>().ReverseMap();
            CreateMap<GenreViewModel, GenreDTO>().ReverseMap();
        }
    }
}
