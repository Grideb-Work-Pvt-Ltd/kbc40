using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace forex.Models
{
    public class pan
    {
        private async Task<string> ConvertToBase64Async(IFormFile file)
        {
            using (var memoryStream = new MemoryStream())
            {
                await file.CopyToAsync(memoryStream);
                byte[] fileBytes = memoryStream.ToArray();
                return Convert.ToBase64String(fileBytes);
            }
        }
        public async Task<panmod> CheckAsync(IFormFile imageFile, string originalFileName, string vid)
        {
            
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Post, "https://api.cashfree.com/verification/document/pan");

                // Add headers
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                request.Headers.Add("x-client-id", "CF458961CP2QF5PRDGT6F8SHAR90");
                request.Headers.Add("x-client-secret", "cfsk_ma_prod_f01e02fa50d1adceb036a819463f5233_a1a7a1d4");

                Random rand = new Random();

                // Generate a random 5-digit number
                int randomNumber = rand.Next(10000, 100000);
                string veri_id = vid + randomNumber.ToString();

                // Prepare the multipart form data
                var content = new MultipartFormDataContent();
                content.Add(new StringContent(veri_id), "verification_id");

                // Convert the IFormFile to a byte array
                byte[] imageBytes;
                using (var memoryStream = new MemoryStream())
                {
                    await imageFile.CopyToAsync(memoryStream);
                    imageBytes = memoryStream.ToArray();
                }

                // Create a ByteArrayContent for the image
                var imageContent = new ByteArrayContent(imageBytes);
                imageContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = "front_image",
                    FileName = originalFileName
                };
                imageContent.Headers.ContentType = new MediaTypeHeaderValue(imageFile.ContentType); // Get the content type from the IFormFile

                // Add the image content to the multipart form data
                content.Add(imageContent);

                // Assign content to the request
                request.Content = content;

                // Send the request
                HttpResponseMessage response = await client.SendAsync(request);

                // Read and display the response
                string responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<panmod>(responseBody);
               
            }
        }
    }
}
