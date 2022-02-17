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

namespace Proje_rehber_class_17_02_2022
{
   
    public partial class HomePage : Form
    {   //-----------------------------------------DEGISKEN ADALANDIRMALARI
        veritabani vr = new veritabani();
        


        public HomePage()
        {
            InitializeComponent();
        }
        //-----------------------------------------------LOAD
        private void HomePage_Load(object sender, EventArgs e)
        {
            
            hastalarigetir();
            
           
        }
        //-----------------------------------------------------HASTALARIGETİR
        void hastalarigetir()
        {
            string sorgucumlesi = "SELECT * FROM tblHastalar";
            dgvHastalar.DataSource = vr.DataGoster(sorgucumlesi);
        }
        //********************************************** YENİ KAYIT SAYFASİ GİRİS
        private void btnYenikayit_Click(object sender, EventArgs e)
        {
            YeniKayit yk = new YeniKayit();
            yk.Show();
            this.Hide();

        }
        // -----------------------------------------------------ANA SAYFAYI KAPATMA
        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();//***************************************************************
        }

        private void btnduzelt_Click(object sender, EventArgs e)
        {
            duzenle dz = new duzenle();
            dz.Show();
            this.Hide();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            sil s = new sil();
            s.Show();
            this.Hide();
        }

        private void btncik_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
