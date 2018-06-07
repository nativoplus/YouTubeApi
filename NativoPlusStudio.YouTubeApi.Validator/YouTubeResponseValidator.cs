using FluentValidation;
using NativoPlusStudio.YouTubeApi.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace NativoPlusStudio.YouTubeApi.Validations
{
   public class YouTubeResponseValidator: AbstractValidator<IYouTubeResponse>
    {
        public YouTubeResponseValidator()
        {
            RuleFor(x => x.VideoData).NotEmpty();
        }
    }
}
