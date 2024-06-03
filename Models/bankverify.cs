using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace forex.Models
{
    public class BankVerify
    {
        public async Task VerifyBankDetails(string bankAccount, string ifsc)
        {
           
            string clientId = "CF458961CP2QF5PRDGT6F8SHAR90";
            string clientSecret = "cfsk_ma_prod_f01e02fa50d1adceb036a819463f5233_a1a7a1d4";

            {

                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Post, "https://payout-api.cashfree.com/payout/v1/authorize");
                request.Headers.Add("X-Cf-Signature", "sdf1234");
                request.Headers.Add("X-Client-Secret", "cfsk_ma_prod_f01e02fa50d1adceb036a819463f5233_a1a7a1d4");
                request.Headers.Add("X-Client-Id", "CF458961CP2QF5PRDGT6F8SHAR90");
                request.Headers.Add("accept", "application/json");
                var response = await client.SendAsync(request);
                string responseBody = await response.Content.ReadAsStringAsync();
                response.EnsureSuccessStatusCode();
               // Console.WriteLine(await response.Content.ReadAsStringAsync());
            }

            // Define the URL and query parameters
            string url = "https://payout-api.cashfree.com/payout/v1/asyncValidation/bankDetails";

            // Construct the full URL with query parameters
            string fullUrl = $"{url}?bankAccount={bankAccount}&ifsc={ifsc}";

            // Create a new HttpClient instance
            using (HttpClient client = new HttpClient())
            {
                // Add the Accept header to the client
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Prepare the Basic Authentication header
                string authInfo = $"{clientId}:{clientSecret}";
                string authValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(authInfo));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authValue);

                try
                {
                    // Send the GET request and get the response
                    HttpResponseMessage response = await client.GetAsync(fullUrl);

                    // Read the response content as a string
                    string responseBody = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        // Output the successful response body
                        Console.WriteLine("Success:");
                        Console.WriteLine(responseBody);
                    }
                    else
                    {
                        // Output the error status code and response body
                        Console.WriteLine($"Error: {response.StatusCode}");
                        Console.WriteLine("Response body:");
                        Console.WriteLine(responseBody);
                    }
                }
                catch (HttpRequestException e)
                {
                    // Output any request exception that occurs
                    Console.WriteLine($"Request error: {e.Message}");
                }
            }
        }
    }
}
