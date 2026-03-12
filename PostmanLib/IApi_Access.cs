namespace PostmanLib
{
    public interface IApi_Access
    {
        Task<string> CallApi(string url,string content ,bool isFormatting = true ,HttpAction method = HttpAction.GET);
        Task<string> CallApi(string url ,HttpContent? content=null, bool isFormatting = true, HttpAction method = HttpAction.GET);
        bool IsValidUrl(string url);
    }
}