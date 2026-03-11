namespace PostmanLib
{
    public interface IApi_Access
    {
        Task<string> CallApi(string url, bool isFormatting = true, HttpMethod method = HttpMethod.Get);
        bool IsValidUrl(string url);
    }
}