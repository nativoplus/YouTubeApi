namespace NativoPlusStudio.YouTubeApi.Contracts
{
    public interface IThumbnails
    {
        IDefault @default { get; set; }
        IHigh high { get; set; }
        IMedium medium { get; set; }
    }
}