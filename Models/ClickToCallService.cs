using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace forex.Models
{
    public class ClickToCallService
    {
        private readonly IConfiguration _config;
        private readonly HttpClient _client;


        public ClickToCallService(IConfiguration config, HttpClient client)
        {
            _config = config;
            _client = client;
        }

        public async Task<string> ExecuteClickToCallAsync(string SID, string fromNumber, string toNumber)
        {
            string baseUrl = "https://api.kaleyra.io/v1/";
            string apiKey = "A496ce07795e216b3a5cf6b003fa14a4f";

            string url = $"{baseUrl}{SID}/voice/click-to-call";
            string contentType = "application/x-www-form-urlencoded";
            string bridge = "+911161197301"; // Replace with your actual bridge number if needed
            string prefix = "1"; // Optional
            int retryCount = 2; // Optional
            string dlrUrl = "kbc40.com"; // Optional
            string time = "2009-11-04T19:55:41+05:30"; // Optional
            string callback = "{\"profile_id\":\"your_profile_id\"}"; // Optional

            var values = new FormUrlEncodedContent(new[]
            {
            new KeyValuePair<string, string>("from", fromNumber),
            new KeyValuePair<string, string>("to", toNumber),
            new KeyValuePair<string, string>("bridge", bridge),
            new KeyValuePair<string, string>("prefix", prefix),
            new KeyValuePair<string, string>("retry", retryCount.ToString()),
            new KeyValuePair<string, string>("dlrurl", dlrUrl),
            new KeyValuePair<string, string>("time", time),
            new KeyValuePair<string, string>("callback", callback)
        });

            _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(contentType));
            _client.DefaultRequestHeaders.Add("api-key", apiKey);

            HttpResponseMessage response = await _client.PostAsync(url, values);
            string responseString = await response.Content.ReadAsStringAsync();

            return responseString;
        }
    }
}

