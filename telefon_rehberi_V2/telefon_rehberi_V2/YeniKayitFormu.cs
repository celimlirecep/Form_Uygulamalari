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

namespace telefon_rehberi_V2
{
    
    public partial class YeniKayitFormu : Form
    {
        string sorgucümlesi;
        string baglanticumlesi = @"Server=RECEP-CELIMLI\SQLEXPRESS;Database=Srehber;User=sa;Pwd=123";
        SqlConnection baglanti;
        SqlCommand komut;
        

        public YeniKayitFormu()
        {
            InitializeComponent();
        }

        private void YeniKayitFormu_Load(object sender, EventArgs e)
        {
            cmbcinsiyet.SelectedIndex = 0;
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void YeniKayitFormu_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnkapat.PerformClick();
        }
        void kaydet()
        {
            string ad = txtad.Text;
            string soyad = txtsoyad.Text;
            string tel = txttel.Text;
            char cinsiyet = cmbcinsiyet.Text == "erkek" ? 'E': 'K';
            
          
            sorgucümlesi = $"INSERT INTO tblKisiler VALUES ('{ad}','{soyad}','{cinsiyet}','{tel}')";
            baglanti =new  SqlConnection(baglanticumlesi);
            komut =new  SqlCommand(sorgucümlesi, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            temizle();
        }
        private void temizle()
        {
            txtad.Text = "";
            txtsoyad.Text = "";
            txttel.Text = "";
            cmbcinsiyet.Text = "";
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }

     
    }
    
}
