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
    
    public partial class duzenle : Form
    {
        veritabani vr = new veritabani();

        public duzenle()
        {
            InitializeComponent();
        }
        void tablodagöster()
        {
            string sorgucümlesi = "SELECT * FROM tblHastalar";
            dgvduzeltmetablosu.DataSource = vr.DataGoster(sorgucümlesi);
        }

        private void duzenle_Load(object sender, EventArgs e)
        {
            tablodagöster();
        }

        private void txtcik_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Hide();
        }

        private void duzenle_FormClosing(object sender, FormClosingEventArgs e)
        {
            txtcik.PerformClick();
        }

        void from_tablo_to_text()
        {
            
            txttc.Text = dgvduzeltmetablosu.CurrentRow.Cells[1].Value.ToString();
            txtad.Text = dgvduzeltmetablosu.CurrentRow.Cells[2].Value.ToString();
            txtsoyad.Text = dgvduzeltmetablosu.CurrentRow.Cells[3].Value.ToString();
            txtadres.Text = dgvduzeltmetablosu.CurrentRow.Cells[5].Value.ToString();
            txttelefon.Text = dgvduzeltmetablosu.CurrentRow.Cells[6].Value.ToString();
            txtmail.Text = dgvduzeltmetablosu.CurrentRow.Cells[7].Value.ToString();
            cmbcinsiyet.Text = dgvduzeltmetablosu.CurrentRow.Cells[4].Value.ToString() == "E" ? "ERKEK" : "KADIN";
        }

        private void dgvduzeltmetablosu_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            from_tablo_to_text();
        }

        private void txtdegistir_Click(object sender, EventArgs e)
        {
            string ID = dgvduzeltmetablosu.CurrentRow.Cells[0].Value.ToString();
            string cinsiyet = cmbcinsiyet.Text == "ERKEK" ? "E" : "K";
            vr.duzenle(ID,txttc.Text,txtad.Text,txtsoyad.Text,cinsiyet,txtadres.Text,txttelefon.Text,txtmail.Text);
            tablodagöster();
        }
    }
}
