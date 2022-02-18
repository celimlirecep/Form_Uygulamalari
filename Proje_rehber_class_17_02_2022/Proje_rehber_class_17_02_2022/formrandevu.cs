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
            bolumdoldur();
            doktordoldur();
            hastadoldur();
        }
        void hastadoldur()
        {
            sorgucümlesi = $"SELECT tblhastalar.ID,tblhastalar.ad,tblhastalar.soyad FROM tblhastalar  ";
            dgvHastalar.DataSource = vr.DataGoster(sorgucümlesi);
        }

        private void cmbbolum_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnCik_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string bolumID =cmbbolum.SelectedValue.ToString();
            string doktorlarID =lstdoktorlar.SelectedValue.ToString() ;
            string hastaID = dgvHastalar.CurrentRow.Cells[0].Value.ToString() ;
            string tarih =dtpTarih.Text;
            string saat = dtpsaat.Text;
            sorgucümlesi = $"INSERT INTO tblRandevular VALUES ('{bolumID}','{doktorlarID}','{hastaID}','{tarih}','{saat}')";
            vr.islem(sorgucümlesi);

        }
    }
}
