using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_01_temel_kontroller
{
    public partial class btnSay : Form
    {
        public btnSay()
        {
            InitializeComponent();
        }

        void ekle()
        {
            lstKisiler.Items.Add(txtAdSoyad.Text.ToUpper().Trim());
            // txtAdSoyad.Clear();
            //txtAdSoyad.Text = "";
            txtAdSoyad.ResetText();
            txtAdSoyad.Focus();

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            ekle();
        }

        private void txtAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {

            //e.Handled = e.KeyChar == (char)Keys.Space;
            if (e.KeyChar==(char)Keys.Enter)
            {
                ekle();
                string adSoyad = txtAdSoyad.Text;
                int uzunluk = adSoyad.Length;

                if (uzunluk > 0)
                {

                    int konum = adSoyad.Length - 1;//karakter sayısı -1 dizi sırası

                    if (adSoyad[konum].ToString() == " ")
                    {
                        e.Handled = e.KeyChar == (char)Keys.Space;
                    }
                }
                else
                {
                    e.Handled = e.KeyChar == (char)Keys.Space;
                }
            }

            
          


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"KİŞİ SAYISI: {lstKisiler.Items.Count}");
        }
        void arama()
        {
            string aranan = txtaranan.Text.ToUpper();
            if (lstKisiler.Items.Contains(aranan))
            {
                lblbulunan.Text = aranan;
            }
            else
            {
                lblbulunan.Text = "aradığınız kayıt bulunamadı";
            }
            txtaranan.Clear();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            arama();
        }
        

        private void txtaranan_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((char)Keys.Enter == e.KeyChar)
            {
                arama();
            }
            
        }

        private void txtaranan_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSay_Load(object sender, EventArgs e)
        {

        }

        private void btnSay_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

      
    }
}
