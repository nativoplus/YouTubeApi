using NativoPlusStudio.YouTubeApi.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Versioning.Conventions;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using NativoPlusStudio.YouTubeApi.Controllers;

namespace NativoPlusStudio.YouTubeApi
{
    public static class ApiVersioningConfiguration
    {
        public static void AddCustomApiVersioning(this IServiceCollection services)
        {
            services.AddMvcCore().AddVersionedApiExplorer(o => o.GroupNameFormat = "'v'VVV");
            services.AddApiVersioning(
                options =>
                {
                    //enable advertizing api versions
                    options.ReportApiVersions = true;

                    //versioning by convention instead of attributes
                    options.Conventions.Controller<YouTubeController>()
                                       .HasApiVersion(new ApiVersion(1, 0))
                                       //map new method versions to their respective api versions
                                       //instead of new controllers for new api versions
                                       .Action(c => c.GetYouTubeVideos(default(YouTubeRequest))).MapToApiVersion(new ApiVersion(1, 0));

                }
            );

            services.AddSwaggerGen(
                options =>
                {
                    var provider = services.BuildServiceProvider()
                                           .GetRequiredService<IApiVersionDescriptionProvider>();

                    foreach (var description in provider.ApiVersionDescriptions)
                    {
                        options.SwaggerDoc(
                            description.GroupName,
                            CreateInfo(description)
                        );
                    }
                }
            );
        }

        private static Info CreateInfo(ApiVersionDescription description)
        {
            return new Info()
            {
                Title = $"YouTubeApi {description.ApiVersion}",
                Version = description.ApiVersion.ToString()
            };
        }
    }
}
