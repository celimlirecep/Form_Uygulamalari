using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WithClassSQl_2_Crad
{
    public partial class form_yeni_kayit : Form
    {
        VeriTabani vt = new VeriTabani();
        public form_yeni_kayit()
        {
            InitializeComponent();
        }

       

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            
                string cinsiyet = cmbcinsiyet.Text == "ERKEK" ? "E" : "K";
                lblhatamesaji.Text = "";
                string durum= vt.Ekle(txttc.Text, txtad.Text, txtsoyad.Text, cinsiyet, txtadres.Text, txttelefon.Text, txtmail.Text);
            //  lblYeniKayitDogrulama.Text = "Yeni Kayıt yapıldı...";
            lblhatamesaji.Text = durum;





        }

        private void form_yeni_kayit_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAna anaform = new FormAna();
            anaform.Show();
            this.Hide();
        }
    }
}
