using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Windows.Forms;

namespace CarbEqual
{
    internal class Program
    {
        private static readonly HttpClient client = new HttpClient();

        #region this is where your api key goes - get one here: 
        public static string apiKey = "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";
        #endregion


        public static string endPointURL = "https://api.openai.com/v1/chat/completions";

        public class Message
        {
            public string Content { get; set; }
        }

        public class Choice
        {
            public Message Message { get; set; }
        }

        public class ChatApiResponse
        {
            public List<Choice> Choices { get; set; }
        }
        
        public static async Task Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
        public static async Task<string> AskSomething(string userMessage)
        {
            var assistansMessage = await OpenAIComplete(apiKey, endPointURL, userMessage);
            ChatApiResponse chatResponse = JsonConvert.DeserializeObject<ChatApiResponse>(assistansMessage);
            string responseText = chatResponse.Choices[0].Message.Content;
            return responseText;
        }

        public static async Task<string> OpenAIComplete(string key, string endpoint, string uMsg)
        {
            var payload = new
            {
                model = "gpt-3.5-turbo-0301",
                max_tokens = 500,
                temperature = 0.9,
                messages = new[]
                {
                    new { role = "system", content = "Sen Elektrik Tüketimi Yapan Ciahazlardaki Karbon Ayak İzi Hesaplama Uygulamasısın " +"Kullanıcıdan Sana Mah,Pil Sağlığı, Harcanan Yüzde ve Kullandığı uygulmanın değerlerini versin. Ardından, verilen formüle göre hesaplama yap:"
                    +" Formül : Mah * Pil Sağlığını hesapla Çıkan Sonuc1 değerini 100'e Bölme İşlemi Yap ordan Çıkan Sonuc2 değerini 1000'e Bölme İşlemi Yap Elde edilen Sonuc3 değerini harcanan yüzde ile Çarpma İşlemi Yapıp çıkan Sonuc4 değerini 100'e Bölme İşlemi Yap ve ordan çıkan Sonuc5 değerini kullanılan uygulama voltajıyla Çarpma İşlemi Yap bu voltajı şu uygulamalar için Instagram için 3.3, Twitter için 3.2, PUBG için 3.7, Facebook için 3.1 değerlerini al ve çıkan Sonuc7 değerini 1000'e Bölme İşlemi Yap ordan çıkan sonuc7 değerini (0.478) ile çarpıp En son elde edilen Sonuc8 değer kullanıcının karbon miktarı olarak söyle." } ,

                   new { role = "user", content = $"{uMsg}"}
                }
            };

            string jsonPayload = JsonConvert.SerializeObject(payload);

            var request = new HttpRequestMessage(HttpMethod.Post, endpoint);
            request.Headers.Add("Authorization", $"Bearer {key}");
            request.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            var httpResponse = await client.SendAsync(request);
            string responseContent = await httpResponse.Content.ReadAsStringAsync();

            return responseContent;
        }
    }
}