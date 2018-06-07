using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NativoPlusStudio.YouTubeApi.ConfigurationModel.NativoPlusStudio.YouTubeApi.ConfigurationModel;
using NativoPlusStudio.YouTubeApi.Contracts;
using NativoPlusStudio.YouTubeApi.Requests;
using NativoPlusStudio.YouTubeApi.Responses;
using NativoPlusStudio.YouTubeApi.Services;
using Polly;
using System;
using System.Net.Http;

using System.Net.Http.Headers;

namespace NativoPlusStudio.YouTubeApi.Service
{
    public static class ServicesConfiguration
    {
        public static void ServicesConfigurationForYouTubeApi(this IServiceCollection services, IConfiguration Configuration)
        {
            var retryPolicy = Policy
                .Handle<HttpRequestException>()
                .OrResult<HttpResponseMessage>(message => !message.IsSuccessStatusCode)
                .WaitAndRetryAsync(3, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)));

            var youTubeApiConfig = Configuration.GetSection("YouTubeOptions").Get<YouTubeApiConfig>();
            services.AddScoped<IYouTubeRequest, YouTubeRequest>();
            services.AddScoped<IYouTubeResponse, YouTubeResponse>();
            services.AddScoped<IYouTubeApiConfig, YouTubeApiConfig>();
            services.AddScoped<IYouTubeChannelVideosService, YouTubeChannelVideosService>();
            services.AddScoped<IYouTubeChannelHttpService, YouTubeChannelHttpService>();
            services.Configure<YouTubeApiConfig>(options =>
            {
                Configuration.GetSection("YouTubeOptions").Bind(options);
            });

            services.AddHttpClient<YouTubeChannelHttpService>(client =>
            {

                client.BaseAddress = new Uri(youTubeApiConfig.BaseAddress);
                client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", youTubeApiConfig.UserAgent);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            })
            .AddPolicyHandler(retryPolicy);

        }
    }
}
