using Guna.UI2.WinForms;
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

namespace CarbEqual
{
    public partial class Form6 : Form
    {
        //public float BenzinKgCo2 = 0.00157f ;
        //public float DizelKgCo2 = 0.00182f;
        //public float LPGKgCo2 = 0.00117f;


        public float d_Benzin = 0.74f;
        public float d_Dizel = 0.835f;
        public float d_LPG = 0.55f;

        public float DF_Benzin = 44.3f;
        public float DF_Dizel = 43.0f;
        public float DF_LPG = 47.3f;

        public float EF_Benzin = 69.3f;
        public float EF_Dizel = 74.1f;
        public float EF_LPG = 63.1f;


        public float d_DoğalGaz = 0.67f;
        public float EF_DoğalGaz = 56.1f;
        public float DF_DoğalGaz = 48.0f;

        public float YT;
        public Form6()
        {
            
            InitializeComponent();
            //Araç Modelleri
            

            //Yakıt Türleri
            
            label2.Visible = false;

            AracVisClose();
            YakitVisClose();
        }



        void AracVisClose() 
        {
            AracBox.Visible = false;
            BenzibBox.Visible = false;
            ElectricBox.Visible = false;
            LPGBox.Visible = false;
            DieselBox.Visible = false;
            AracModel.Visible = false;
        }

        void YakitVisClose()
        {
            YakıtBox.Visible = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {
        
            
        }

        private void Form6_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
       
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if (comboBox2.Text == "DoğalGaz")
            //{
            //    AracModel.Items.Clear();
            //    AracModel.Items.Add("Eklenecek");
            //}
            //if (comboBox2.Text == "Elektrik")
            //{
            //    AracModel.Items.Clear();
            //    AracModel.Items.Add("Eklencek");
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
           

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            
        }

        private void button7_Click(object sender, EventArgs e)
        {
           

            
            
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AracPic_MouseClick(object sender, MouseEventArgs e)
        {
            guna2Transition1.HideSync(guna2PictureBox_p);

            guna2PictureBox_p.Image = ((Guna2PictureBox)sender).Image;

            guna2Transition1.ShowSync(guna2PictureBox_p);

            YakıtBox.Items.Clear();

            AracBox.Items.Add("Benzin");
            AracBox.Items.Add("LPG");
            AracBox.Items.Add("Dizel");

            YakitVisClose();
            //Araç
                    
            AracBox.Visible = true;
            BenzibBox.Visible = true;
            ElectricBox.Visible = true;
            LPGBox.Visible = true;
            DieselBox.Visible = true;
            AracModel.Visible = true;

        }

        private void guna2PictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            guna2Transition1.HideSync(guna2PictureBox_p);

            guna2PictureBox_p.Image = ((Guna2PictureBox)sender).Image;

            guna2Transition1.ShowSync(guna2PictureBox_p);

            YakıtBox.Items.Add("Doğal Gaz");
            YakıtBox.Items.Add("Elektrik");

            AracVisClose();

            YakıtBox.Visible = true;
            AracBox.Items.Clear();

        }

        private void BenzibBox_MouseClick(object sender, MouseEventArgs e)
        {
            AracBox.Text = "Benzin";
        }

        private void ElectricBox_MouseClick(object sender, MouseEventArgs e)
        {
            AracBox.Text = "Elektrik";
        }

        private void LPGBox_MouseClick(object sender, MouseEventArgs e)
        {
            AracBox.Text = "LPG";
        }

        private void DieselBox_MouseClick(object sender, MouseEventArgs e)
        {
            AracBox.Text = "Dizel";
        }

        private void AracModel_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void AracBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AracBox.Text == "Benzin")
            {
                AracModel.Items.Clear();
                AracModel.Items.Add("Honda Civic 2015");
                AracModel.Items.Add("Renault Clio 2021");
                AracModel.Items.Add("BMW 320i 2016");
                AracModel.Items.Add("Volkswagen Seri Jetta 2015");
                AracModel.Items.Add("Mercedes-Benz CLA 200 2013");
                
            }


            //if (AracBox.Text == "Elektrik")
            //{

            //    AracModel.Items.Clear();
            //    AracModel.Items.Add("Tesla");
            //    AracModel.Items.Add("Tesla");
            //    AracModel.Items.Add("Tesla");
            //    AracModel.Items.Add("Tesla");
            //    AracModel.Items.Add("Tesla");
            //}

            if (AracBox.Text == "Dizel")
            {
                AracModel.Items.Clear();
                AracModel.Items.Add("Toyota Corolla 2016");
                AracModel.Items.Add("Fiat Egea 2019");
                AracModel.Items.Add("Volkswagen Passat 2015");
                AracModel.Items.Add("Chrysler Model 3.0 CRD 2006");
                AracModel.Items.Add("Hyundai Accent Blue 2016");

            }
            if (AracBox.Text == "LPG")
            {
                AracModel.Items.Clear();
                AracModel.Items.Add("Renault Megane2 2007");
                AracModel.Items.Add("Peugeot 206 2006");
                AracModel.Items.Add("Tofaş Şahin 1992");
                AracModel.Items.Add("Opel Vectra 1999");
                AracModel.Items.Add("Subaru Impreza 2007");

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //Benzin
            if (AracModel.Text == "Honda Civic 2015")
            {
                YT = 0.09f;
                float HondaKGCO2 = ((YT * d_Benzin * 0.001f) * DF_Benzin * 0.001f) * EF_Benzin;
                //1000 Metrede  Üretilen KGCO2

                float BenzinUsed = (Form5.KgCO2Value / HondaKGCO2);

                MessageBox.Show("Benzinli Araç ile " + BenzinUsed.ToString() + " Metre Yol gitmiş Kadar Karbon Ayak İzi Ürettiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (AracModel.Text == "Renault Clio 2021")
            {
                YT = 0.063f;
                float HondaKGCO2 = ((YT * d_Benzin * 0.001f) * DF_Benzin * 0.001f) * EF_Benzin;
                //1000 Metrede  Üretilen KGCO2

                float BenzinUsed = (Form5.KgCO2Value / HondaKGCO2);

                MessageBox.Show("Benzinli Araç ile " + BenzinUsed.ToString() + " Metre Yol gitmiş Kadar Karbon Ayak İzi Ürettiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (AracModel.Text == "BMW 320i 2016")
            {
                YT = 0.073f;
                float HondaKGCO2 = ((YT * d_Benzin * 0.001f) * DF_Benzin * 0.001f) * EF_Benzin;
                //1000 Metrede  Üretilen KGCO2

                float BenzinUsed = (Form5.KgCO2Value / HondaKGCO2);

                MessageBox.Show("Benzinli Araç ile " + BenzinUsed.ToString() + " Metre Yol gitmiş Kadar Karbon Ayak İzi Ürettiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (AracModel.Text == "Volkswagen Seri Jetta 2015")
            {
                YT = 0.06f;
                float HondaKGCO2 = ((YT * d_Benzin * 0.001f) * DF_Benzin * 0.001f) * EF_Benzin;
                //1000 Metrede  Üretilen KGCO2

                float BenzinUsed = (Form5.KgCO2Value / HondaKGCO2);

                MessageBox.Show("Benzinli Araç ile " + BenzinUsed.ToString() + " Metre Yol gitmiş Kadar Karbon Ayak İzi Ürettiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (AracModel.Text == "Mercedes-Benz CLA 200 2013")
            {
                YT = 0.074f;
                float HondaKGCO2 = ((YT * d_Benzin * 0.001f) * DF_Benzin * 0.001f) * EF_Benzin;
                //1000 Metrede  Üretilen KGCO2

                float BenzinUsed = (Form5.KgCO2Value / HondaKGCO2);

                MessageBox.Show("Benzinli Araç ile " + BenzinUsed.ToString() + " Metre Yol gitmiş Kadar Karbon Ayak İzi Ürettiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }




            //DİZEL
            if (AracModel.Text == "Toyota Corolla 2016")
            {
                YT = 0.049f;
                float ToyotaKGCO2 = ((YT * d_Dizel * 0.001f) * DF_Dizel * 0.001f) * EF_Dizel;
                //1000 Metrede  Üretilen KGCO2

                float DizelUsed = (Form5.KgCO2Value / ToyotaKGCO2);
                MessageBox.Show("Dİzel Araç ile: " + DizelUsed.ToString() + " Metre Yol gitmiş Kadar Karbon Ayak İzi Ürettiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (AracModel.Text == "Fiat Egea 2019")
            {
                YT = 0.045f;
                float ToyotaKGCO2 = ((YT * d_Dizel * 0.001f) * DF_Dizel * 0.001f) * EF_Dizel;
                //1000 Metrede  Üretilen KGCO2

                float DizelUsed = (Form5.KgCO2Value / ToyotaKGCO2);
                MessageBox.Show("Dİzel Araç ile: " + DizelUsed.ToString() + " Metre Yol gitmiş Kadar Karbon Ayak İzi Ürettiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (AracModel.Text == "Volkswagen Passat 2015")
            {
                YT = 0.045f;
                float ToyotaKGCO2 = ((YT * d_Dizel * 0.001f) * DF_Dizel * 0.001f) * EF_Dizel;
                //1000 Metrede  Üretilen KGCO2

                float DizelUsed = (Form5.KgCO2Value / ToyotaKGCO2);
                MessageBox.Show("Dİzel Araç ile: " + DizelUsed.ToString() + " Metre Yol gitmiş Kadar Karbon Ayak İzi Ürettiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (AracModel.Text == "Chrysler Model 3.0 CRD 2006")
            {
                YT = 0.108f;
                float ToyotaKGCO2 = ((YT * d_Dizel * 0.001f) * DF_Dizel * 0.001f) * EF_Dizel;
                //1000 Metrede  Üretilen KGCO2

                float DizelUsed = (Form5.KgCO2Value / ToyotaKGCO2);
                MessageBox.Show("Dİzel Araç ile: " + DizelUsed.ToString() + " Metre Yol gitmiş Kadar Karbon Ayak İzi Ürettiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (AracModel.Text == "Hyundai Accent Blue 2016")
            {
                YT = 0.057f;
                float ToyotaKGCO2 = ((YT * d_Dizel * 0.001f) * DF_Dizel * 0.001f) * EF_Dizel;
                //1000 Metrede  Üretilen KGCO2

                float DizelUsed = (Form5.KgCO2Value / ToyotaKGCO2);
                MessageBox.Show("Dİzel Araç ile: " + DizelUsed.ToString() + " Metre Yol gitmiş Kadar Karbon Ayak İzi Ürettiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            //LPG
            if (AracModel.Text == "Renault Megane2 2007")
            {
                YT = 0.102f;
                float RenaultKGCO2 = ((YT * d_LPG * 0.001f) * DF_LPG * 0.001f) * EF_LPG;
                //1000 Metrede  Üretilen KGCO2

                float LPGUsed = (Form5.KgCO2Value / RenaultKGCO2);
                MessageBox.Show("LPG'li Araç ile " + LPGUsed.ToString() + " Metre Yol gitmiş Kadar Karbon Ayak İzi Ürettiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (AracModel.Text == "Peugeot 206 2006")
            {
                YT = 0.095f;
                float RenaultKGCO2 = ((YT * d_LPG * 0.001f) * DF_LPG * 0.001f) * EF_LPG;
                //1000 Metrede  Üretilen KGCO2

                float LPGUsed = (Form5.KgCO2Value / RenaultKGCO2);
                MessageBox.Show("LPG'li Araç ile " + LPGUsed.ToString() + " Metre Yol gitmiş Kadar Karbon Ayak İzi Ürettiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (AracModel.Text == "Tofaş Şahin 1992")
            {
                YT = 0.068f;
                float RenaultKGCO2 = ((YT * d_LPG * 0.001f) * DF_LPG * 0.001f) * EF_LPG;
                //1000 Metrede  Üretilen KGCO2

                float LPGUsed = (Form5.KgCO2Value / RenaultKGCO2);
                MessageBox.Show("LPG'li Araç ile " + LPGUsed.ToString() + " Metre Yol gitmiş Kadar Karbon Ayak İzi Ürettiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (AracModel.Text == "Opel Vectra 1999")
            {
                YT = 0.121f;
                float RenaultKGCO2 = ((YT * d_LPG * 0.001f) * DF_LPG * 0.001f) * EF_LPG;
                //1000 Metrede  Üretilen KGCO2

                float LPGUsed = (Form5.KgCO2Value / RenaultKGCO2);
                MessageBox.Show("LPG'li Araç ile " + LPGUsed.ToString() + " Metre Yol gitmiş Kadar Karbon Ayak İzi Ürettiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (AracModel.Text == "Subaru Impreza 2007")
            {
                YT = 0.104f;
                float RenaultKGCO2 = ((YT * d_LPG * 0.001f) * DF_LPG * 0.001f) * EF_LPG;
                //1000 Metrede  Üretilen KGCO2

                float LPGUsed = (Form5.KgCO2Value / RenaultKGCO2);
                MessageBox.Show("LPG'li Araç ile " + LPGUsed.ToString() + " Metre Yol gitmiş Kadar Karbon Ayak İzi Ürettiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            if (YakıtBox.Text == "Doğal Gaz")
            {

                YT = 1000f;
                float DogalGazKGCO2 = ((YT * d_DoğalGaz * 0.001f) * DF_DoğalGaz * 0.001f) * EF_DoğalGaz;
                //1000 MetreKüp Üretilen KGCO2

                float LPGUsed = (Form5.KgCO2Value / DogalGazKGCO2);
                MessageBox.Show(LPGUsed.ToString() + " Metreküp Doğalgaz Yakmış Kadar Karbon Ayak İzi Ürettiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (YakıtBox.Text == "Elektrik")
            {                
                MessageBox.Show(Form5.kWhValue.ToString() + " KWH Elektrik Kullanmış Kadar Karbon Ayak İzi Ürettiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string UsedKgCO2Value = Form5.KgCO2Value.ToString();
            guna2ComboBox4.Items.Add(UsedKgCO2Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Owner = this;
            f5.Show();

            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Owner = this;
            f2.Show();

            this.Hide();
        }

        private void guna2PictureBox_p_Click(object sender, EventArgs e)
        {

        }

        private void YakıtBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            AracModel.Items.Clear();
        }

        private void AracPic_Click(object sender, EventArgs e)
        {
            YakıtBox.Items.Clear();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Owner = this;
            f3.Show();

            this.Hide();
        }
    }

        
    
}
