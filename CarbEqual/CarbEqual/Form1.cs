using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Data.SQLite;

namespace CarbEqual
{
    public partial class Form1 : Form
    {
       

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader reader;

        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
            }
        }   

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Owner = this;
            f4.Show();

            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sqlitedb_constr = "Data Source=.\\Login.db;Version=3;";
            con = new SQLiteConnection(sqlitedb_constr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;
            //con = new SqlConnection("Data Source = DESKTOP-JB4VKAF; Initial Catalog = Ornek; Integrated Security = True");
            //com = new SqlCommand();
            con.Open();
            cmd = new SQLiteCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select*From Kullanici_Bilgi where kullanici_adi='" + textBox1.Text +
                    "'and sifre='" + textBox2.Text + "'";

            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Form2 f2 = new Form2();
                f2.Owner = this;
                f2.Show();

                this.Hide();               

            }
            else
            {
                MessageBox.Show("Veri Setine Bağlanmadı");
                    
            }
            con.Close();
            if (textBox1.Text == "Admin")
            {
                if (textBox2.Text == "Admin")
                {
                    Form2 f2 = new Form2();
                    f2.Owner = this;
                    f2.Show();

                    this.Hide();
                }
            }

          
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //uygulama büyük ekran için
            //if (WindowState == FormWindowState.Normal)
            //    this.WindowState = FormWindowState.Maximized;
            //else
            //    this.WindowState = FormWindowState.Normal;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
