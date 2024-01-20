// MIT License
// 
// Copyright (c) 2024 Russell Camo (Russkyc)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using System.Net.Http;
using System.Threading.Tasks;
using OcrSpace.Sharp.Utils;

namespace OcrSpace.Sharp
{
    public class OcrSpaceClient
    {
        private const string ApiEndpoint = "/parse/image";
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public OcrSpaceClient(string apiKey)
        {
            _apiKey = apiKey;
            _httpClient = new()
            {
                BaseAddress = new Uri("https://api.ocr.space")
            };
        }

        public async Task<string> ReadFromFile(string filePath, string? imageType = null)
        {
            var image = filePath.ToParsedImageFile();
            
            var requestContent = new MultipartFormDataContent();
            requestContent.Add(new StringContent(_apiKey), "apikey");
            requestContent.Add(image.fileContent, "file", image.file);
            
            var response = await _httpClient.PostAsync(ApiEndpoint, requestContent);
            var result = await response.Content.ReadAsStringAsync();
            
            return result.ParseResult();
        }
        
        public async Task<string> ReadFromBytes(byte[] fileBytes, string fileName)
        {
            var imageContent = new ByteArrayContent(fileBytes);
            
            var requestContent = new MultipartFormDataContent();
            requestContent.Add(new StringContent(_apiKey), "apikey");
            requestContent.Add(imageContent, "file", fileName); 

            var response = await _httpClient.PostAsync(ApiEndpoint, requestContent);
            var result = await response.Content.ReadAsStringAsync();
            
            return result.ParseResult();
        }
    }
}