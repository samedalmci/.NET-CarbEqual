using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace CarbEqual
{
    public partial class Form5 : Form
    {
        public float mAhValue;
        public float Voltaj;
        public float PhoneEmisyonFac = 0.478f;
        public static float KgCO2Value;
        public static float kWhValue;




        public Form5()
        {
            InitializeComponent();

            //Iphone
            IphoneVisClose();

            //Xiaomi
            XiaomiVisClose();

            //Samsung
            SamsungVisClose();
        }

        void IphoneVisClose()
        {
            IPhoneBox.Visible = false;
            ıphone12Box.Visible = false;
            Iphone14proBox.Visible = false;
            ıphone15promaxBox.Visible = false;
            ıphone15proBox.Visible = false;
            ıphone14promaxBox.Visible = false;
            ıphone13promaxBox.Visible = false;
            ıphone13Box.Visible = false;
            ıphone12promaxBox.Visible = false;
            ıphonee11Box.Visible = false;
            iPhoneXRBox.Visible = false;

        }

        void XiaomiVisClose()
        {
            XiaomiBox.Visible = false;
            redminote9proBox.Visible = false;
            redminote10proBox.Visible = false;
            xiomi13proBox.Visible = false;
            xiomimi11Box.Visible = false;
            xiomimi10Box.Visible = false;
            xiomimi11liteBox.Visible = false;
            xiomiminote10liteBox.Visible = false;
            xiomimi9tBox.Visible = false;
            xiomiredmi9tBox.Visible = false;
            xiomiredminote7Box.Visible = false;
        }

        void SamsungVisClose()
        {
            SamsungBox.Visible = false;

            samsungs23Box.Visible = false;
            samsungnote10Box.Visible = false;
            Samsunggalaxyzfold5Box.Visible = false;
            Samsunggalaxyzfold4Box.Visible = false;
            Samsunggalaxyzflip5Box.Visible = false;
            Samsungs22Box.Visible = false;
            Samsungs21Box.Visible = false;
            samsunggalakxya52Box.Visible = false;
            samsugnote20Box .Visible = false;
            samsungnote9Box.Visible = false;



        }
        private void CalculateAndShowCarbonFootprint()
        {
            float BatteryHealth = float.Parse(guna2ComboBox4.Text);
            float mAhValueNew = (mAhValue * BatteryHealth) / 100f;
            float AhValue = mAhValueNew / 1000f;
            float UsedBattery = float.Parse(guna2ComboBox6.Text);
            float UsedAhValue = (AhValue * UsedBattery) / 100f;
            kWhValue = (UsedAhValue * Voltaj) / 1000f;
            float KgCO2 = PhoneEmisyonFac * kWhValue;
            KgCO2Value = KgCO2;

            MessageBox.Show("Ürettiğiniz Karbon Ayak İzi Değeri(KgCo2): " + KgCO2.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Iphone
        public void Iphone15ProMaxValues()
        {
            mAhValue = 3274;

            CalculateAndShowCarbonFootprint();
        }

        public void Iphone15ProValues()
        {
            mAhValue = 3274;

            CalculateAndShowCarbonFootprint();
        }

        public void Iphone14ProMaxValues()
        {
            mAhValue = 4323;

            CalculateAndShowCarbonFootprint();
        }

        public void Iphone14ProValue()
        {
            mAhValue = 3200;

            CalculateAndShowCarbonFootprint();
        }

        public void Iphone13ProMaxValues()
        {
            mAhValue = 4352;

            CalculateAndShowCarbonFootprint();
        }

        public void Iphone13Values()
        {
            mAhValue = 3227;

            CalculateAndShowCarbonFootprint();
        }

        public void Iphone12ProMaxValues()
        {
            mAhValue = 3687;

            CalculateAndShowCarbonFootprint();
        }

        public void Iphone12Values()
        {
            mAhValue = 2815;

            CalculateAndShowCarbonFootprint();
        }

        public void Iphone11Values()
        {
            mAhValue = 3110;

            CalculateAndShowCarbonFootprint();
        }
        public void IphoneXRValues()
        {
            mAhValue = 2942;

            CalculateAndShowCarbonFootprint();

        }


        //Xiomi
        public void RedmiNote9Values()
        {
            mAhValue = 5020;
            CalculateAndShowCarbonFootprint();
        }

        public void RedmiNote10Values()
        {
            mAhValue = 5020;
            CalculateAndShowCarbonFootprint();
        }

        public void Mi11Values()
        {
            mAhValue = 4600;
            CalculateAndShowCarbonFootprint();
        }

        public void Mi10Values()
        {
            mAhValue = 4780;
            CalculateAndShowCarbonFootprint();
        }

        public void Mi11LiteValues()
        {
            mAhValue = 4250;
            CalculateAndShowCarbonFootprint();
        }

        public void MiNote10LiteValues()
        {
            mAhValue = 5260;
            CalculateAndShowCarbonFootprint();
        }

        public void Mi9TValues()
        {
            mAhValue = 4000;
            CalculateAndShowCarbonFootprint();
        }

        public void Redmi9TValues()
        {
            mAhValue = 6000;
            CalculateAndShowCarbonFootprint();
        }

        public void RedmiNote7Values()
        {
            mAhValue = 4000;
            CalculateAndShowCarbonFootprint();
        }

        public void x13ProValues()
        {
            mAhValue = 4820;
            CalculateAndShowCarbonFootprint();
        }


        //Samsung
        public void GalaxyZFold5Values()
        {
            mAhValue = 4400;
            CalculateAndShowCarbonFootprint();
        }

        public void GalaxyZFold4Values()
        {
            mAhValue = 4400;
            CalculateAndShowCarbonFootprint();
        }

        public void GalaxyZFlip5Values()
        {
            mAhValue = 3700;
            CalculateAndShowCarbonFootprint();
        }

        public void S23Values()
        {
            mAhValue = 3900;
            CalculateAndShowCarbonFootprint();
        }

        public void S22Values()
        {
            mAhValue = 5000;
            CalculateAndShowCarbonFootprint();
        }

        public void S21Values()
        {
            mAhValue = 5000;
            CalculateAndShowCarbonFootprint();
        }

        public void GalaxyA52Values()
        {
            mAhValue = 4500;
            CalculateAndShowCarbonFootprint();
        }

        public void Note20Values()
        {
            mAhValue = 4300;
            CalculateAndShowCarbonFootprint();
        }

        public void Note10Values()
        {
            mAhValue = 3500;
            CalculateAndShowCarbonFootprint();
        }

        public void Note9Values()
        {
            mAhValue = 4000;
            CalculateAndShowCarbonFootprint();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Owner = this;
            f6.Show();

            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Owner = this;
            f2.Show();

            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void Form5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox5_MouseClick(object sender, MouseEventArgs e)
        {




        }

        private void guna2PictureBox2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void guna2PictureBox3_MouseClick(object sender, MouseEventArgs e)
        {


        }



        private void guna2PictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox5.Text == "Instagram")
            {
                Voltaj = 3.3f;
            }
            if (guna2ComboBox5.Text == "Twitter")
            {
                Voltaj = 3.2f;
            }
            if (guna2ComboBox5.Text == "PUBG")
            {
                Voltaj = 3.7f;
            }
            if (guna2ComboBox5.Text == "Facebook")
            {
                Voltaj = 3.1f;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //Iphone
            
            if (IPhoneBox.Text == "15 Pro Max")
            {
                Iphone15ProMaxValues();
            }
            if (IPhoneBox.Text == "15 Pro")
            {
                Iphone15ProValues();
            }
            if (IPhoneBox.Text == "14 Pro Max")
            {
                Iphone14ProMaxValues();
            }
            if (IPhoneBox.Text == "14 Pro")
            {
                Iphone14ProValue();
            }
            if (IPhoneBox.Text == "13 Pro Max")
            {
                Iphone13ProMaxValues();
            }
            if (IPhoneBox.Text == "13")
            {
                Iphone13Values();
            }
            if (IPhoneBox.Text == "12 Pro Max")
            {
                Iphone12ProMaxValues();
            }
            if (IPhoneBox.Text == "12")
            {
                Iphone12Values();
            }
            if (IPhoneBox.Text == "11")
            {
                Iphone11Values();
            }
            if (IPhoneBox.Text == "XR")
            {
                IphoneXRValues();
            }

            //Xiaomi

            if (XiaomiBox.Text == "Redmi Not 9")
            {
                RedmiNote9Values();
            }
            if (XiaomiBox.Text == "Redmi Not 10")
            {
                RedmiNote10Values();
            }
            if (XiaomiBox.Text == "Mi 11")
            {
                Mi11Values();
            }
            if (XiaomiBox.Text == "Mi 10")
            {
                Mi10Values();
            }
            if (XiaomiBox.Text == "Mi 11 Lite")
            {
                Mi11LiteValues();
            }
            if (XiaomiBox.Text == "Mi Note 10 Lite")
            {
                MiNote10LiteValues();
            }
            if (XiaomiBox.Text == "Mi 9t")
            {
                Mi9TValues();
            }
            if (XiaomiBox.Text == "13 Pro")
            {
                x13ProValues();
            }
            if (XiaomiBox.Text == "Redmi 9t")
            {
                Redmi9TValues();
            }
            if (XiaomiBox.Text == "Redmi Note 7")
            {
                RedmiNote7Values();
            }

            //Samsung

            if (SamsungBox.Text == "Galaxy z Fold 5")
            {
                GalaxyZFold5Values();
            }
            if (SamsungBox.Text == "Galaxy z Fold 4")
            {
                GalaxyZFold4Values();
            }
            if (SamsungBox.Text == "Galaxy z Flip 5")
            {
                GalaxyZFlip5Values();
            }
            if (SamsungBox.Text == "S23")
            {
                S23Values();
            }
            if (SamsungBox.Text == "S22")
            {
                S22Values();
            }
            if (SamsungBox.Text == "S21")
            {
                S21Values();
            }
            if (SamsungBox.Text == "Galaxy a 52")
            {
                GalaxyA52Values();
            }
            if (SamsungBox.Text == "Note 20")
            {
                Note20Values();
            }
            if (SamsungBox.Text == "Note 10")
            {
                Note10Values();
            }
            if (SamsungBox.Text == "Note 9")
            {
                Note9Values();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void guna2PictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
                 
        }

        private void IPhoneBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IPhoneBox.Text == "15 Pro Max")
            {
                guna2Transition1.HideSync(ıphone11Box);

                // ıphone11Box'un resmini S23Box'un resmiyle değiştir
                ıphone11Box.Image = ıphone15promaxBox.Image;

                guna2Transition1.ShowSync(ıphone11Box);
            }
            if (IPhoneBox.Text == "15 Pro")
            {
                guna2Transition1.HideSync(ıphone11Box);

                // ıphone11Box'un resmini S23Box'un resmiyle değiştir
                ıphone11Box.Image = ıphone15proBox.Image;

                guna2Transition1.ShowSync(ıphone11Box);
            }
            if (IPhoneBox.Text == "14 Pro Max")
            {
                guna2Transition1.HideSync(ıphone11Box);

                // ıphone11Box'un resmini S23Box'un resmiyle değiştir
                ıphone11Box.Image = ıphone14promaxBox.Image;

                guna2Transition1.ShowSync(ıphone11Box);
            }
            if (IPhoneBox.Text == "14 Pro")
            {
                guna2Transition1.HideSync(ıphone11Box);

                // ıphone11Box'un resmini S23Box'un resmiyle değiştir
                ıphone11Box.Image = Iphone14proBox.Image;

                guna2Transition1.ShowSync(ıphone11Box);
            }
            if (IPhoneBox.Text == "13 Pro Max")
            {
                guna2Transition1.HideSync(ıphone11Box);

                // ıphone11Box'un resmini S23Box'un resmiyle değiştir
                ıphone11Box.Image = ıphone13promaxBox.Image;

                guna2Transition1.ShowSync(ıphone11Box);
            }
            if (IPhoneBox.Text == "13")
            {
                guna2Transition1.HideSync(ıphone11Box);

                // ıphone11Box'un resmini S23Box'un resmiyle değiştir
                ıphone11Box.Image = ıphone13Box.Image;

                guna2Transition1.ShowSync(ıphone11Box);
            }
            if (IPhoneBox.Text == "12 Pro Max")
            {
                guna2Transition1.HideSync(ıphone11Box);

                // ıphone11Box'un resmini S23Box'un resmiyle değiştir
                ıphone11Box.Image = ıphone12promaxBox.Image;

                guna2Transition1.ShowSync(ıphone11Box);
            }
            if (IPhoneBox.Text == "12")
            {
                guna2Transition1.HideSync(ıphone11Box);

                // ıphone11Box'un resmini S23Box'un resmiyle değiştir
                ıphone11Box.Image = ıphone12Box.Image;

                guna2Transition1.ShowSync(ıphone11Box);
            }
            if (IPhoneBox.Text == "11")
            {
                guna2Transition1.HideSync(ıphone11Box);

                // ıphone11Box'un resmini S23Box'un resmiyle değiştir
                ıphone11Box.Image = ıphonee11Box.Image;

                guna2Transition1.ShowSync(ıphone11Box);
            }
            if (IPhoneBox.Text == "XR")
            {
                guna2Transition1.HideSync(ıphone11Box);

                // ıphone11Box'un resmini S23Box'un resmiyle değiştir
                ıphone11Box.Image = iPhoneXRBox.Image;

                guna2Transition1.ShowSync(ıphone11Box);
            }

        }

        private void XiaomiBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (XiaomiBox.Text == "Redmi Not 9")
            {
                guna2Transition1.HideSync(ıphone11Box);

                // ıphone11Box'un resmini S23Box'un resmiyle değiştir
                ıphone11Box.Image = redminote9proBox.Image;

                guna2Transition1.ShowSync(ıphone11Box);
            }
            if (XiaomiBox.Text == "Redmi Not 10")
            {
                guna2Transition1.HideSync(ıphone11Box);

                // ıphone11Box'un resmini S23Box'un resmiyle değiştir
                ıphone11Box.Image = redminote10proBox.Image;

                guna2Transition1.ShowSync(ıphone11Box);
            }
            if (XiaomiBox.Text == "13 Pro")
            {
                guna2Transition1.HideSync(ıphone11Box);

                // ıphone11Box'un resmini S23Box'un resmiyle değiştir
                ıphone11Box.Image = xiomi13proBox.Image;

                guna2Transition1.ShowSync(ıphone11Box);
            }
            if (XiaomiBox.Text == "Mi 11")
            {
                guna2Transition1.HideSync(ıphone11Box);

                // ıphone11Box'un resmini S23Box'un resmiyle değiştir
                ıphone11Box.Image = xiomimi11Box.Image;

                guna2Transition1.ShowSync(ıphone11Box);
            }
            if (XiaomiBox.Text == "Mi 10")
            {
                guna2Transition1.HideSync(ıphone11Box);

                // ıphone11Box'un resmini S23Box'un resmiyle değiştir
                ıphone11Box.Image = xiomimi10Box.Image;

                guna2Transition1.ShowSync(ıphone11Box);
            }
            if (XiaomiBox.Text == "Mi 11 Lite")
            {
                guna2Transition1.HideSync(ıphone11Box);

                // ıphone11Box'un resmini S23Box'un resmiyle değiştir
                ıphone11Box.Image = xiomimi11liteBox.Image;

                guna2Transition1.ShowSync(ıphone11Box);
            }
            if (XiaomiBox.Text == "Mi Note 10 Lite")
            {
                guna2Transition1.HideSync(ıphone11Box);

                // ıphone11Box'un resmini S23Box'un resmiyle değiştir
                ıphone11Box.Image = xiomiminote10liteBox.Image;

                guna2Transition1.ShowSync(ıphone11Box);
            }
            if (XiaomiBox.Text == "Mi 9t")
            {
                guna2Transition1.HideSync(ıphone11Box);

                // ıphone11Box'un resmini S23Box'un resmiyle değiştir
                ıphone11Box.Image = xiomimi9tBox.Image;

                guna2Transition1.ShowSync(ıphone11Box);
            }
            if (XiaomiBox.Text == "Redmi 9t")
            {
                guna2Transition1.HideSync(ıphone11Box);

                // ıphone11Box'un resmini S23Box'un resmiyle değiştir
                ıphone11Box.Image = xiomiredmi9tBox.Image;

                guna2Transition1.ShowSync(ıphone11Box);
            }
            if (XiaomiBox.Text == "Redmi Note 7")
            {
                guna2Transition1.HideSync(ıphone11Box);

                // ıphone11Box'un resmini S23Box'un resmiyle değiştir
                ıphone11Box.Image = xiomiredminote7Box.Image;

                guna2Transition1.ShowSync(ıphone11Box);
            }

        }

        private void SamsungBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SamsungBox.Text == "Galaxy z Fold 5")
            {
                guna2Transition1.HideSync(ıphone11Box);

                // ıphone11Box'un resmini S23Box'un resmiyle değiştir
                ıphone11Box.Image = Samsunggalaxyzfold5Box.Image;

                guna2Transition1.ShowSync(ıphone11Box);
            }
            if (SamsungBox.Text == "Galaxy z Fold 4")
            {
                guna2Transition1.HideSync(ıphone11Box);

                // ıphone11Box'un resmini S23Box'un resmiyle değiştir
                ıphone11Box.Image = Samsunggalaxyzfold4Box.Image;

                guna2Transition1.ShowSync(ıphone11Box);
            }
            if (SamsungBox.Text == "Galaxy z Flip 5")
            {
                guna2Transition1.HideSync(ıphone11Box);

                // ıphone11Box'un resmini S23Box'un resmiyle değiştir
                ıphone11Box.Image = Samsunggalaxyzflip5Box.Image;

                guna2Transition1.ShowSync(ıphone11Box);
            }
            if (SamsungBox.Text == "S23")
            {
                guna2Transition1.HideSync(ıphone11Box);

                // ıphone11Box'un resmini S23Box'un resmiyle değiştir
                ıphone11Box.Image = samsungs23Box.Image;

                guna2Transition1.ShowSync(ıphone11Box);
            }
            if (SamsungBox.Text == "S22")
            {
                guna2Transition1.HideSync(ıphone11Box);

                // ıphone11Box'un resmini S23Box'un resmiyle değiştir
                ıphone11Box.Image = Samsungs22Box.Image;

                guna2Transition1.ShowSync(ıphone11Box);
            }
            if (SamsungBox.Text == "S21")
            {
                guna2Transition1.HideSync(ıphone11Box);

                // ıphone11Box'un resmini S23Box'un resmiyle değiştir
                ıphone11Box.Image = Samsungs21Box.Image;

                guna2Transition1.ShowSync(ıphone11Box);
            }
            if (SamsungBox.Text == "Galaxy a 52")
            {
                guna2Transition1.HideSync(ıphone11Box);

                // ıphone11Box'un resmini S23Box'un resmiyle değiştir
                ıphone11Box.Image = samsunggalakxya52Box.Image;

                guna2Transition1.ShowSync(ıphone11Box);
            }
            if (SamsungBox.Text == "Note 20")
            {
                guna2Transition1.HideSync(ıphone11Box);

                // ıphone11Box'un resmini S23Box'un resmiyle değiştir
                ıphone11Box.Image = samsugnote20Box.Image;

                guna2Transition1.ShowSync(ıphone11Box);
            }
            if (SamsungBox.Text == "Note 10")
            {
                guna2Transition1.HideSync(ıphone11Box);

                // ıphone11Box'un resmini S23Box'un resmiyle değiştir
                ıphone11Box.Image = samsungnote10Box.Image;

                guna2Transition1.ShowSync(ıphone11Box);
            }
            if (SamsungBox.Text == "Note 9")
            {
                guna2Transition1.HideSync(ıphone11Box);

                // ıphone11Box'un resmini S23Box'un resmiyle değiştir
                ıphone11Box.Image = samsungnote9Box.Image;

                guna2Transition1.ShowSync(ıphone11Box);
            }

        }


        //SoLResimler
        private void IPhonePic_MouseClick(object sender, MouseEventArgs e)
        {
            guna2Transition1.HideSync(ıphone11Box);

            ıphone11Box.Image = ((Guna2PictureBox)sender).Image;

            guna2Transition1.ShowSync(ıphone11Box);

            //vis
            IPhoneBox.Visible = true;
            ıphone14promaxBox.Visible = true;
            Iphone14proBox.Visible = true;
            ıphone15promaxBox.Visible = true;
            ıphone15proBox.Visible = true;
            ıphone12Box.Visible = true;
            ıphone13promaxBox.Visible = true;
            ıphone13Box.Visible = true;
            ıphone12promaxBox.Visible = true;
            ıphonee11Box.Visible = true;
            iPhoneXRBox.Visible = true;

            //Xiaomi
            XiaomiVisClose();

            //Samsung
            SamsungVisClose();
        }

        private void XiaomiPic_MouseClick(object sender, MouseEventArgs e)
        {
            guna2Transition1.HideSync(ıphone11Box);

            ıphone11Box.Image = ((Guna2PictureBox)sender).Image;

            guna2Transition1.ShowSync(ıphone11Box);

            //vis
            XiaomiBox.Visible = true;
            redminote9proBox.Visible = true;
            redminote10proBox.Visible = true;
            xiomi13proBox.Visible = true;
            xiomimi11Box.Visible = true;
            xiomimi10Box.Visible = true;
            xiomimi11liteBox.Visible = true;
            xiomiminote10liteBox.Visible = true;
            xiomimi9tBox.Visible = true;
            xiomiredmi9tBox.Visible = true;
            xiomiredminote7Box.Visible = true;

            //Xiaomi
            IphoneVisClose();

            //Samsung
            SamsungVisClose();
        }
        
        private void SamsungPic_MouseClick(object sender, MouseEventArgs e)
        {
            guna2Transition1.HideSync(ıphone11Box);

            ıphone11Box.Image = ((Guna2PictureBox)sender).Image;

            guna2Transition1.ShowSync(ıphone11Box);

            //vis
            SamsungBox.Visible = true;
            samsungs23Box.Visible = true;
            samsungnote10Box.Visible = true;
            Samsunggalaxyzfold5Box.Visible = true;
            Samsunggalaxyzfold4Box.Visible = true;
            Samsunggalaxyzflip5Box.Visible = true;
            Samsungs22Box.Visible = true;
            Samsungs21Box.Visible = true;
            samsunggalakxya52Box.Visible = true;
            samsugnote20Box.Visible = true;
            samsungnote9Box.Visible = true;

            //Xiaomi
            XiaomiVisClose();

            //Samsung
            IphoneVisClose();
        }






        private void Samsunggalaxyzflip5Box_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox8_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void ıphone11Box_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void IPhonePic_Click(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Owner = this;
            f3.Show();

            this.Hide();
        }

        private void XiaomiPic_Click(object sender, EventArgs e)
        {

        }
    }



}
