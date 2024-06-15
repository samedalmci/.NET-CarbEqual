using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace CarbEqual
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            LoadQuestionsAndAnswers();
            guna2TextBox2.ReadOnly = true;
          
        }
        private List<SoruCevap> sorular;
        public class JsonData
        {
            public List<SoruCevap> sorular { get; set; }
        }
        public class SoruCevap
        {
            public string soru { get; set; }
            public string cevap { get; set; }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void LoadQuestionsAndAnswers()
        {
            try
            {
                string filePath = @"C:\Users\Berat Can\Desktop\GömülüSistemler\GömülüSistemler\GömülüSistemler\jsondosyası\veritabani.json";
           

                // JSON dosyasını oku ve içeriği bir JsonData nesnesine yükle
                string jsonContent = File.ReadAllText(filePath);
                JsonData jsonData = JsonConvert.DeserializeObject<JsonData>(jsonContent);

                // Soru ve cevapları al
                sorular = jsonData.sorular;
            }
            catch (Exception ex)
            {
                MessageBox.Show("JSON dosyası yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        private void ShowQuestions()
        {
            StringBuilder message = new StringBuilder();

            foreach (var soruCevap in sorular)
            {
                message.AppendLine("Soru: " + soruCevap.soru);
                message.AppendLine("Cevap: " + soruCevap.cevap);
                message.AppendLine(); // Bir sonraki soru ve cevap arasında bir boşluk bırakmak için

                // İsterseniz burada bir limit koyarak sadece belirli bir sayıda soruyu gösterebilirsiniz.
                // Örneğin, sadece ilk 10 soruyu göstermek için:
                // if (message.Length > MAX_MESSAGE_LENGTH) break;
            }

            MessageBox.Show(message.ToString(), "Sorular", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button1_Click_3(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private bool IsSimilar(string input, string comparison)
        {
            // Küçük harfe dönüştür
            string lowerInput = input.ToLower();
            string lowerComparison = comparison.ToLower();

            // Karşılaştırma için bir eşik değeri belirleyin (örneğin, %60 benzerlik)
            double threshold = 0.60;

            // Karakterlerin farklılığını hesapla
            int diffCount = 0;
            for (int i = 0; i < Math.Min(lowerInput.Length, lowerComparison.Length); i++)
            {
                if (lowerInput[i] != lowerComparison[i])
                {
                    diffCount++;
                }
            }

            // Dizelerin uzunlukları farklıysa, uzunluk farkını ekleyin
            diffCount += Math.Abs(lowerInput.Length - lowerComparison.Length);

            // Benzerlik oranını hesapla
            double similarity = 1 - (double)diffCount / Math.Max(lowerInput.Length, lowerComparison.Length);

            // Eğer benzerlik oranı eşik değerden büyükse true döndür
            return similarity >= threshold;
        }

        

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Owner = this;
            f2.Show();

            this.Hide();
        }

        private void button1Json_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Owner = this;
            f5.Show();

            this.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Owner = this;
            f6.Show();

            this.Hide();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            string userInput = guna2TextBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                MessageBox.Show("Lütfen bir soru veya ifade girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool found = false;
            string similarQuestion = "";
            foreach (SoruCevap item in sorular)
            {
                if (IsSimilar(userInput, item.soru))
                {
                    similarQuestion = item.soru;
                    found = true;
                    break;
                }
            }

            if (found)
            {
                // Benzer sorunun cevabını göster
                string answer = sorular.Find(x => x.soru == similarQuestion)?.cevap;
                //MessageBox.Show("Benzer soru: " + similarQuestion + "\nCevap: " + answer, "Benzer Soru ve Cevap", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cevabı guna2TextBox2'ye atama
                guna2TextBox2.Text = answer;
            }
            else
            {
                MessageBox.Show("Girdiğiniz ifadeye benzer bir soru bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

