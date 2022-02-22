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
    public partial class formrandevu : Form
    {
        veritabani vr = new veritabani();
        string sorgucümlesi;
        public formrandevu()
        {
            InitializeComponent();
        }
        
        void bolumdoldur()
        {
            cmbbolum.DataSource = vr.DataGoster("SELECT * FROM tblBolumler");
            cmbbolum.DisplayMember = "BOLUMID";
            cmbbolum.ValueMember = "ID";
        }
      void doktordoldur()
        {
            string bolumID = cmbbolum.SelectedValue.ToString();
            sorgucümlesi = $"SELECT * FROM tblDoktorlar WHERE BolumID='{bolumID}'";
            lstdoktorlar.DataSource = vr.DataGoster(sorgucümlesi);
            lstdoktorlar.DisplayMember = "adSoyad";
            lstdoktorlar.ValueMember = "ID";
        }

        private void formrandevu_Load(object sender, EventArgs e)
        {
            hastadoldur();
            bolumdoldur();
            doktordoldur();


        }
        void hastadoldur()
        {
            sorgucümlesi = $"SELECT tblhastalar.ID,tblhastalar.ad,tblhastalar.soyad FROM tblhastalar  ";
            dgvHastalar.DataSource = vr.DataGoster(sorgucümlesi);
        }

       
        private void btnCik_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Hide();

             
        }
        void kaydet()
        {
            string bolumID = cmbbolum.SelectedValue.ToString();
            string doktorlarID = lstdoktorlar.SelectedValue.ToString();
            string hastaID = dgvHastalar.CurrentRow.Cells[1].Value.ToString();

                 string tarih = dtpTarih.Text;
            string saat = dtpsaat.Text;
            sorgucümlesi = $"INSERT INTO tblRandevular VALUES ('{bolumID}','{doktorlarID}','{hastaID}','{tarih}','{saat}')";
            vr.islem(sorgucümlesi);
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string bolumAD = cmbbolum.Text;
            string doktorlarAD = lstdoktorlar.Text;
            string hastaAD = dgvHastalar.CurrentRow.Cells[1].Value.ToString() + " "+dgvHastalar.CurrentRow.Cells[2].Value.ToString();
            string tarih = dtpTarih.Text;
            hocarandevuonizleme frg = new hocarandevuonizleme(bolumAD, hastaAD, doktorlarAD, tarih);
            frg.Show();
            







            kaydet();// DİĞER FORMDAN GELEN VERİYE GÖRE KAYDEDİLECEK

            
            
            
           

        }

        private void dgvHastalar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txthasta.Text = $"{dgvHastalar.CurrentRow.Cells[1].Value.ToString()} {dgvHastalar.CurrentRow.Cells[2].Value.ToString()}";
            
        }

        private void cmbbolum_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                doktordoldur();
            }
            catch (Exception)
            {

                // throw;
            }
        }

        private void formrandevu_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnCik.PerformClick();
        }

        void dolumu()
        {
            if (vr.kayitkontrol(txthasta.Text, cmbbolum.Text, lstdoktorlar.Text))
            {
                btnKaydet.Enabled = true;
            }
        }

        private void dtpsaat_ValueChanged(object sender, EventArgs e)
        {
                dolumu();
        }
    }


}
