using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace forex.Models
{
    public class aadhar
    {
        private async Task<byte[]> ConvertToByteArrayAsync(IFormFile file)
        {
            using (var memoryStream = new MemoryStream())
            {
                await file.CopyToAsync(memoryStream);
                return memoryStream.ToArray();
            }
        }

        public async Task<adharv> adCheckAsync(IFormFile frontImageFile, string frontImageFileName, IFormFile backImageFile, string backImageFileName,string vid)
        {
           
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Post, "https://api.cashfree.com/verification/document/aadhaar");

                // Add headers
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                request.Headers.Add("x-client-id", "CF458961CP2QF5PRDGT6F8SHAR90");
                request.Headers.Add("x-client-secret", "cfsk_ma_prod_f01e02fa50d1adceb036a819463f5233_a1a7a1d4");

                Random rand = new Random();

                // Generate a random 5-digit number
                int randomNumber = rand.Next(10000, 100000);
                string veri_id = vid+randomNumber.ToString();
                // Prepare the multipart form data
                var content = new MultipartFormDataContent();
                content.Add(new StringContent(veri_id), "verification_id");

                // Convert front image file to byte array
                byte[] frontImageBytes = await ConvertToByteArrayAsync(frontImageFile);

                // Create ByteArrayContent for the front image
                var frontImageContent = new ByteArrayContent(frontImageBytes);
                frontImageContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = "front_image",
                    FileName = frontImageFileName
                };
                frontImageContent.Headers.ContentType = new MediaTypeHeaderValue(frontImageFile.ContentType);

                // Add the front image content to the multipart form data
                content.Add(frontImageContent);

                // Convert back image file to byte array
                byte[] backImageBytes = await ConvertToByteArrayAsync(backImageFile);

                // Create ByteArrayContent for the back image
                var backImageContent = new ByteArrayContent(backImageBytes);
                backImageContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = "back_image",
                    FileName = backImageFileName
                };
                backImageContent.Headers.ContentType = new MediaTypeHeaderValue(backImageFile.ContentType);

                // Add the back image content to the multipart form data
                content.Add(backImageContent);

                // Assign content to the request
                request.Content = content;

                // Send the request
                HttpResponseMessage response = await client.SendAsync(request);

                // Read and display the response
                string responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<adharv>(responseBody);

               
            }
        }


    }
}
