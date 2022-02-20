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
            
           // hastalarigetir();
            
           
        }
        //-----------------------------------------------------HASTALARIGETİR
       /* void hastalarigetir()
        {
           string sorgucumlesi = "SELECT * FROM tblHastalar";
            dgvHastalar.DataSource = vr.DataGoster(sorgucumlesi);
        }*/
        //********************************************** YENİ KAYIT SAYFASİ GİRİS
      
        // -----------------------------------------------------ANA SAYFAYI KAPATMA
        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();//***************************************************************
        }

       

      

        private void btncik_Click(object sender, EventArgs e)//***** PROGRAMDAN ÇIK
        {
            Application.Exit();
        }

        private void btnHASTALAR_Click(object sender, EventArgs e)
        {
          
            formhastalar dz = new formhastalar();
            dz.Show();
            this.Hide();

        }

        private void btnbolum_Click(object sender, EventArgs e)
        {
            formbolumler bf = new formbolumler();
            bf.Show();
            this.Hide();
        }

        private void btnrandevu_Click(object sender, EventArgs e)
        {
            formrandevu FR = new formrandevu();
            FR.Show();
            this.Hide();
        }

        private void tblrandevutakip_Click(object sender, EventArgs e)
        {
            form_Randevu_Onizleme ro = new form_Randevu_Onizleme();
            ro.Show();
            this.Hide();
        }
    }
}
