namespace NativoPlusStudio.YouTubeApi.Contracts
{
    public interface IItem
    {
        string etag { get; set; }
        IId id { get; set; }
        string kind { get; set; }
        ISnippet snippet { get; set; }
    }
}