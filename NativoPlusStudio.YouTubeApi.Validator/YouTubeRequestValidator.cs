using FluentValidation;
using NativoPlusStudio.YouTubeApi.Contracts;

namespace NativoPlusStudio.YouTubeApi.Validations
{
    public class YouTubeRequestValidator: AbstractValidator<IYouTubeRequest>
    {
        public YouTubeRequestValidator()
        {
            RuleFor(x => x.channelId).NotEmpty();
        }
    }
}
