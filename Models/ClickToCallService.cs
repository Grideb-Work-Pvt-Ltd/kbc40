using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace forex.Models
{
    public class ClickToCallService
    {
        private readonly HttpClient _client;
        private readonly IConfiguration _configuration;

        public ClickToCallService(HttpClient client, IConfiguration configuration)
        {
            _client = client;
            _configuration = configuration;
        }

        public async Task<string> ExecuteClickToCallAsync(string id,string mob)
        {
            var url = "https://api.kaleyra.io/v1/HXIN1696817637IN/voice/outbound";

            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Add("api-key", "A496ce07795e216b3a5cf6b003fa14a4f");

            var data = new Dictionary<string, string>
            {
                { "to", "+91"+mob },
                { "retry", "2" },
                { "bridge", "+911161197301" },
              //  { "target", "[{\"message\":{\"language\":\"en-IN\", \"speed\":\"medium\", \"text\":\"This is test call. Thank you\"}}]" }
                { "target", "[{\"sound\":["+id+"]}]" }
            };

            var content = new FormUrlEncodedContent(data);

            try
            {
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/x-www-form-urlencoded");

                var response = await _client.PostAsync(url, content);
                response.EnsureSuccessStatusCode(); // Throws an exception if the HTTP response status is not successful
                string responseString = await response.Content.ReadAsStringAsync();
                return responseString;
            }
            catch (HttpRequestException e)
            {
                // Handle error
                return $"Request error: {e.Message}";
            }
        }
    }
}
