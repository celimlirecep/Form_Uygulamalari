using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_rehber_class_17_02_2022
{
    public partial class YeniKayit : Form
    {
        veritabani vr = new veritabani();
        public YeniKayit()
        {
            InitializeComponent();
        }
        //-------------------------------ANA SAYFAYA DÖNÜŞ
        private void btnCık_Click(object sender, EventArgs e)
        {
            formhastalar dz = new formhastalar();
            dz.Show();
            this.Hide();
        }
        //----------------------------- ANA SAYFAYA DÖNÜŞ X
        private void YeniKayit_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnCık.PerformClick();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string cinsiyet = cmbcinsiyet.Text == "ERKEK" ? "E" : "K";
            string sqlkomutlari = $"INSERT INTO tblHastalar VALUES ('{txttc.Text}','{txtad.Text}','{txtsoyad.Text}','{cinsiyet}','{txtadres.Text}','{txttel.Text}','{txtmail.Text}')";

           
            string yeniKayitEklemeDurumu="Yeni Kayıt Eklenemedi...";
            if (vr.kayitkontrol(txttc.Text,txtad.Text, txtsoyad.Text, cinsiyet))
            {
               yeniKayitEklemeDurumu= vr.islem(sqlkomutlari);
            }
            lblYenikayitBidiri.Text = yeniKayitEklemeDurumu;
           
        }
    }
}
