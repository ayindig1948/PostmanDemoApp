using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace PostmanLib
{
    public class Api_Access : IApi_Access
    {
        private readonly HttpClient _client = new();
        public Api_Access()
        { }
        public bool IsValidUrl(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                return false;
            }
            bool isValid = Uri.TryCreate(url, UriKind.Absolute, out Uri? uriResult)
                    && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            return isValid;
        }
        // 
        public async Task<string> CallApi(string url, string content, bool isFormatting = true,
         HttpAction  method = HttpAction.GET)
        { 
        StringContent stringContent = new(content, Encoding.UTF8, "application/json");
            return await CallApi(url, stringContent, isFormatting, method);
        }
        public async Task<string> CallApi(string url,HttpContent? content=null, bool isFormatting = true,
            HttpAction method = HttpAction.GET)
        {
            // Simulate API call
          HttpResponseMessage result;
            switch(method)
            {
                case HttpAction.GET    :
                    result = await _client.GetAsync(url);
                    break;
                case HttpAction.POST  :
                    result = await _client.PostAsync(url, content);
                    break;
                case HttpAction.PUT:
                    result = await _client.PutAsync(url, content);
                    break;
                case HttpAction.DELETE:
                    result = await _client.DeleteAsync(url);
                    break;
                case HttpAction.PATCH:
                    var request = new HttpRequestMessage(new HttpMethod("PATCH"), url) { Content = content };
                    result = await _client.SendAsync(request);
                    break;
               
                default:
                    throw new InvalidOperationException("Unsupported HTTP method");
            }
          
            if (result.IsSuccessStatusCode)
            {
                var json = await result.Content.ReadAsStringAsync();
                if (isFormatting == true)
                {
                    var jsonEl = JsonSerializer.Deserialize<JsonElement>(json);
                    json = JsonSerializer.Serialize(jsonEl, new JsonSerializerOptions { WriteIndented = true });
                }

                return json;
            }
            else
            {
                return $"Error: {result.StatusCode}";
            }
            // Here you would implement the actual API call logic using HttpClient or similar
        }
    }
}
