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
    public partial class formbolumler : Form
    {
        string sorgucümlesi;
        veritabani vt = new veritabani();
       
        public formbolumler()
        {
            InitializeComponent();
        }
        void tabloyenile()
        {
            sorgucümlesi = $"SELECT * FROM tblBolumler";
            dgvBolumler.DataSource = vt.DataGoster(sorgucümlesi);
        }

        private void formbolumler_Load(object sender, EventArgs e)
        {
            tabloyenile();
        }
     
  

        private void dgvBolumler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {


            txtBolum.Text = dgvBolumler.CurrentRow.Cells[1].Value.ToString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string ID = dgvBolumler.CurrentRow.Cells[0].Value.ToString();
            sorgucümlesi = $"UPDATE tblBolumler SET  bolumID='{txtBolum.Text}' WHERE ID='{ID}' ";
            vt.islem(sorgucümlesi);
            tabloyenile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Hide();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            string ID = dgvBolumler.CurrentRow.Cells[0].Value.ToString();
            sorgucümlesi = $"DELETE FROM tblBolumler WHERE ID='{ID}'";
            vt.islem(sorgucümlesi);
            tabloyenile();
        }

        private void formbolumler_FormClosing(object sender, FormClosingEventArgs e)
        {
            btncik.PerformClick();
        }

        private void btnyenikayit_Click(object sender, EventArgs e)
        {
            if (btnyenikayit.Text != "YENİ KAYIT")
            {
               
                if (vt.kayitkontrol(txtBolum.Text))
                {
                    sorgucümlesi = $"INSERT INTO tblBolumler VALUES ('{txtBolum.Text}')";
                    vt.islem(sorgucümlesi);
                    tabloyenile();
                    btnyenikayit.Text = "YENİ KAYIT";
                    lblBolumAD.Text = "BOLUMLER :";
                }
                else
                {
                    lblBolumAD.Text="BOŞ GİRİLMEZ...";
                }

            }
            else
            {
                btnyenikayit.Text = "KAYDET";
              

            }
            txtBolum.Clear();

        }
    }
}
