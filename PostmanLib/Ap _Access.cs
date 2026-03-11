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
        public async Task<string> CallApi(string url, bool isFormatting = true, HttpMethod method = HttpMethod.Get)
        {
            // Simulate API call
            var result = await _client.GetAsync(url);
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
