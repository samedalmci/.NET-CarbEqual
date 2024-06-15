using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CarbEqual
{
    public partial class Form2 : Form
    {
        public static Form2 Instance { get; private set; }
        private static readonly HttpClient client = new HttpClient();
        private const string apiKey = "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"; // Buraya kendi API anahtarınızı ekleyin

        public Form2()
        {
            Instance = this;
            InitializeComponent();
            guna2TextBox2.ReadOnly = true;

            // Authorization üst bilgisini sadece bir kez ekleyin
            if (!client.DefaultRequestHeaders.Contains("Authorization"))
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

       
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
           
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                    

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Owner = this;
            f5.Show();

            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Owner = this;
            f6.Show();

            this.Hide();
        }

        private void XiaomiPic_Click(object sender, EventArgs e)
        {

        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            string userMessage = guna2TextBox1.Text;

            if (!string.IsNullOrWhiteSpace(userMessage))
            {
                guna2TextBox2.Text = "Yanıt bekleniyor...";
                string answer = await AskSomething(userMessage);
                guna2TextBox2.Text = answer.Replace("\n", Environment.NewLine);
            }
        }
       
        private void button1_Click_3(object sender, EventArgs e)
        {
          
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
          


        }

        private async Task<string> AskSomething(string userMessage)
        {
            // Kullanıcı girdilerini kontrol et
            if (!ValidateUserInputs(out string validationMessage))
            {
                return validationMessage;
            }

            // Önceden belirlenmiş bir prompt
            string prompt = "Elektrik Tüketimi Yapan Cihazlardaki Karbon Ayak İzi Hesaplama Uygulamasısı" + userMessage + "\nDoğru hali: ";

            var requestBody = new
            {
                model = "gpt-4",
                messages = new[]
                {
                    new { role = "system", content = 
                    "Kullanıcıdan Sana Mah, Pil Sağlığı, Harcanan Yüzde ve Kullandığı uygulamanın değerlerini versin. Ardından, verilen formüle göre hesaplama yap: " +
                    "Formül: Mah * Pil Sağlığını hesapla, Çıkan Sonuç1 değerini 100'e Bölme İşlemi Yap, oradan Çıkan Sonuç2 değerini 1000'e Bölme İşlemi Yap, " +
                    "Elde edilen Sonuç3 değerini harcanan yüzde ile Çarpma İşlemi Yapıp çıkan Sonuç4 değerini 100'e Bölme İşlemi Yap ve oradan çıkan Sonuç5 değerini " +
                    "kullanılan uygulama voltajıyla Çarpma İşlemi Yap, bu voltajı şu uygulamalar için Instagram için 3.3, Twitter için 3.2, PUBG için 3.7, Facebook için 3.1 değerlerini al " +
                    "ve çıkan Sonuç7 değerini 1000'e Bölme İşlemi Yap, oradan çıkan Sonuç7 değerini (0.478) ile çarpıp En son elde edilen Sonuç8 değeri kullanıcının karbon miktarı olarak söyle.\" " },
                    new { role = "user", content = prompt }
                },
                //max_tokens = 100
            };

            var requestJson = JsonConvert.SerializeObject(requestBody);
            var content = new StringContent(requestJson, Encoding.UTF8, "application/json");

            Console.WriteLine("API'ye gönderilen istek:");
            Console.WriteLine(requestJson);

            try
            {
                var response = await client.PostAsync("https://api.openai.com/v1/chat/completions", content);
                var responseString = await response.Content.ReadAsStringAsync();

                Console.WriteLine("API'den gelen yanıt:");
                Console.WriteLine(responseString);

                if (response.IsSuccessStatusCode)
                {
                    dynamic jsonResponse = JsonConvert.DeserializeObject(responseString);
                    if (jsonResponse != null && jsonResponse.choices != null && jsonResponse.choices[0].message != null && jsonResponse.choices[0].message.content != null)
                    {
                        return jsonResponse.choices[0].message.content.ToString();
                    }
                    else
                    {
                        return "Yanıt alınamadı.";
                    }
                }
                else
                {
                    return $"Hata: {response.StatusCode} - {responseString}";
                }
            }
            catch (Exception ex)
            {
                return $"İstisna oluştu: {ex.Message}";
            }
        }

        private bool ValidateUserInputs(out string validationMessage)
        {
            // Kullanıcıdan alınan girdileri kontrol edin
            // Bu örnekte, sadece kullanıcı girdisinin boş olup olmadığını kontrol ediyoruz.
            // Daha gelişmiş kontroller eklemek isterseniz bu kısmı genişletebilirsiniz.
            if (string.IsNullOrWhiteSpace(guna2TextBox1.Text))
            {
                validationMessage = "Lütfen Mah, Pil Sağlığı, Harcanan Yüzde ve Kullandığınız uygulamanın değerlerini girin.";
                return false;
            }

            validationMessage = string.Empty;
            return true;
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            guna2TextBox2.Multiline = true;
            guna2TextBox2.ScrollBars = ScrollBars.Vertical;
            // Kullanıcı girdilerini kontrol et
            if (!ValidateUserInputs(out string validationMessage))
            {
                guna2TextBox2.Text = validationMessage;
            }
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Owner = this;
            f3.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void IPhonePic_Click(object sender, EventArgs e)
        {

        }
    }

}
