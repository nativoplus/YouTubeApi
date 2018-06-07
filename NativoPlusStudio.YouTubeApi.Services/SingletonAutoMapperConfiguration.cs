using AutoMapper;
using NativoPlusStudio.YouTubeApi.Contracts;
using NativoPlusStudio.YouTubeApi.Responses;
using System;
using System.Linq;

namespace NativoPlusStudio.YouTubeApi.Services
{
    public class SingletonAutoMapperConfiguration
    {
        private static readonly Lazy<SingletonAutoMapperConfiguration> lazy =
            new Lazy<SingletonAutoMapperConfiguration>(() => new SingletonAutoMapperConfiguration());

        public IMapper GetMapper { get; set; }
        public static SingletonAutoMapperConfiguration Instance = lazy.Value;

        private SingletonAutoMapperConfiguration()
        {
            SetUpMapper();
        }

        private void SetUpMapper()
        {
            if (GetMapper != null) return;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<IYouTubeDTO, IYouTubeResponse>()
                .ForMember(dest => dest.VideoData, sp => sp.MapFrom(src => src.items.Select(x => new VideoData()
                {
                    VideoUrl = $"https://www.youtube.com/watch?v={x.id.videoId}",
                    ThumbnailUrl = x.snippet.thumbnails.@default.url,
                    Title = x.snippet.title
                }
                )))
                .As<YouTubeResponse>();
            });

            GetMapper = config.CreateMapper();
        }
    }
}