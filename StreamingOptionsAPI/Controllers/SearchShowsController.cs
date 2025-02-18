using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using Newtonsoft.Json;
using StreamingOptionsAPI.DTO;
using StreamingOptionsAPI.Model;

namespace StreamingOptionsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchShowsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ILogger<SearchShowsController> _logger;

        public SearchShowsController(IMapper mapper, ILogger<SearchShowsController> logger)
        {
            _mapper = mapper;
            _logger = logger;
        } 
            

        [EnableRateLimiting("fixed")]
        [HttpGet(Name = "SearchByTitle")]
        public async Task<List<MovieViewModel>> Get(string title)
        {
            _logger.LogInformation("Movie searched {title}", title);
            var client = new HttpClient();
            var baseUrl = "https://streaming-availability.p.rapidapi.com/shows/search/title?country=br";
            string? rapidApiKey = Environment.GetEnvironmentVariable("api_key");

            if(rapidApiKey == null)
            {
                throw new ArgumentNullException("API KEY not found");
            }

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{baseUrl}&title={title}&series_granularity=show&show_type=movie"),
                Headers =
                {
                    { "x-rapidapi-key", rapidApiKey },
                    { "x-rapidapi-host", "streaming-availability.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();
                var movies = JsonConvert.DeserializeObject<List<MovieStreamResponseDTO>>(json);
                var retorno = _mapper.Map<List<MovieViewModel>>(movies);
                return retorno;
            }
        }
    }
}
