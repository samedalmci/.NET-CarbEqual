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
    public partial class Form4 : Form
    {
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader reader;
        public Form4()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox3.UseSystemPasswordChar = true;
            }
            else
            {
                textBox3.UseSystemPasswordChar = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Owner = this;
            f1.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

     //       SqlConnection con = new SqlConnection("Data Source = DESKTOP-JB4VKAF; Initial Catalog = Ornek; Integrated Security = True");
     //       SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Kullanici_Bilgi]
     //      ([kullanici_adi]
     //      ,[sifre])
     //VALUES
     //      ('"+textBox1.Text+"','"+textBox2.Text+"')", con);
     //       con.Open();
     //       cmd.ExecuteNonQuery();
     //       con.Close();
     //       MessageBox.Show("Kaydınız Başarılı");

            string user = textBox1.Text;
            string password = textBox2.Text;

            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(@"INSERT INTO Kullanici_Bilgi (kullanici_adi, sifre) VALUES (@username, @password)", con);
            cmd.Parameters.AddWithValue("@username", user);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Kaydınız Başarılı");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string sqlitedb_constr = "Data Source=.\\Login.db;Version=3;";
            con = new SQLiteConnection(sqlitedb_constr);
        }

        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
