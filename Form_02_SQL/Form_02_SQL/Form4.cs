using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_02_SQL
{
    public partial class Form4 : Form
    {
    
        SqlConnection baglanti = null;
        SqlCommand komut = null;
        SqlDataReader dr = null;
        string sorgucumlesi = "";
        string ad = "";
        int sayac = 1;
        string baglantiCumlesi = @"Server=RECEP-CELIMLI\SQLEXPRESS;Database=Sirket10;User=sa;Pwd=123";
        public Form4()
        {
            InitializeComponent();

        }
        void status()
        {
            lblStatus.Text += ".";
           
            sayac++;
        }
        void login()
        {
             ad = txtUsername.Text;
            string pass = txtPass.Text;
            sorgucumlesi = $"SELECT * FROM tblUsers WHERE UserName='{ad}' AND  Pass='{pass}'";
            baglanti = new SqlConnection(baglantiCumlesi);
            komut = new SqlCommand(sorgucumlesi, baglanti);
            baglanti.Open();
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                timer1.Start();
                timerYukle.Start();
                lblStatus.Text = "Giris Basarili";
                
            }
            else
            {
                lblStatus.Text = "Giriş başarısız";
            }
            baglanti.Close();
        }

        private void btnLogın_Click(object sender, EventArgs e)
        {
            login();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayac<=1)
            {
                status();
            }
            else
            {
                timer1.Stop();
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();

            }
           
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                login();
                btnLogın.PerformClick();
               
            }
        }

        private void timerYukle_Tick(object sender, EventArgs e)
        {
            lblYukle.Text += $"-{ad}-z";
        }
    }
}
