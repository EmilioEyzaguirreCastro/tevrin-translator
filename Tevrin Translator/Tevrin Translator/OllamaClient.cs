using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http;


namespace Tevrin_Translator
{
    public class OllamaClient
    {
        // Cliente http
        private static readonly HttpClient httpClient = new HttpClient();

        // Funcion del request
        public async Task<string> Request(string prompt)
        {
            var requestBody = new
            {
                model = "mistral",
                messages = new[]
                {
                    new { role = "user", content = prompt }
                },

                stream = false
            };

            string json = JsonSerializer.Serialize(requestBody);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("http://localhost:11434/api/chat", content);
            string result = await response.Content.ReadAsStringAsync();

            using var doc = JsonDocument.Parse(result);
            string answer = doc.RootElement
                .GetProperty("message")
                .GetProperty("content")
                .GetString();

            return answer;

        }
    }
}
